using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using sicotyc.contracts;
using sicotyc.entities.DataTransferObjects;
using sicotyc.entities.Models;
using sicotyc.entities.RequestFeatures;
using sicotyc.Server.ActionFilters;
using sicotyc.Server.ModelBinders;
using sicotyc.service.contracts;

namespace sicotyc.Server.Controllers
{
    [Route("api/driver")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IAuthenticationManager _authManager;
        private readonly IRepositoryManager _repository;
        private readonly IConfiguration _configuration;
        private readonly IServiceManager _service;

        public DriverController(ILoggerManager logger,
            IMapper mapper,
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager,
            IAuthenticationManager authManager,
            IRepositoryManager repository,
            IConfiguration configuration,
            IServiceManager service)
        {
            _authManager = authManager;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _repository = repository;
            _configuration = configuration;
            _service = service;
        }

        #region CRUD Driver

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidationTokenFilter))]
        public async Task<IActionResult> RegisterDriver([FromBody] DriverForRegistrationDto driverForRegistration)
        {
            try
            {
                var currentUserDto = await GetUserInfoFromToken();
                var driverEntity = _mapper.Map<Driver>(driverForRegistration);                
                driverEntity.CreatedBy = currentUserDto != null ? currentUserDto.Id : "system";

                _service.Driver.CreateDriver(driverEntity);
                await _repository.SaveAsync();

                var driverToReturn = _mapper.Map<DriverForRegistrationDto>(driverEntity);

                return CreatedAtRoute("DriverById", new { id = driverToReturn.DriverId }, driverToReturn);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Hubo un error al tratar de registrar al conductor aca el detalle: {ex.Message}");
                return BadRequest("Hubo un error en la ejecucion del metodo");
            }
        }

        [HttpGet("driver/{id:guid}", Name = "DriverById")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetDriver(Guid id)
        {            
            var driver = await _service.Driver.GetDriverByIdAsync(id, trackChanges: false);
            if (driver == null)
            {
                _logger.LogError($"El conductor con id {id} no existe en la base de datos.");
                return NotFound();
            }
            else {
                var driverLicenses = await _repository.DriverLicense.GetDriverLicensesByDriverAsync(id, trackChanges: false);
                if (!driverLicenses.Any())
                {
                    driver.DriverLicenses = driverLicenses.ToList();
                }

                var driverDto = _mapper.Map<DriverDto>(driver);
                return Ok(driverDto);
            }
        }

        [HttpGet("driver/docNumber/{docNumber}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetDriverByIDRuc(string docNumber)
        {
            var driver = await _service.Driver.GetDriverByDocumentNumberAsync(docNumber, trackChanges: false);
            if (driver == null)
            {
                //_logger.LogError($"El conductor con documento {docNumber} no existe en la base de datos.");
                return NoContent();
            }
            else
            {
                var driverLicenses = await _repository.DriverLicense.GetDriverLicensesByDriverAsync(driver.DriverId, trackChanges: false);
                if (!driverLicenses.Any())
                {
                    driver.DriverLicenses = driverLicenses.ToList();
                }

                var driverDto = _mapper.Map<DriverDto>(driver);
                return Ok(driverDto);
            }
        }

        [HttpGet("GetDrivers")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetDrivers([FromQuery] DriverParameters driverParameters)
        {
            try
            {
                var currentUserDto = await GetUserInfoFromToken();
                var driversDb = await _service.Driver.GetAllDriversAsync(driverParameters, currentUserDto.Ruc, currentUserDto.Roles[0] == "Administrator", trackChanges: false);
                if (driversDb.Any())
                {
                    foreach (var driver in driversDb) 
                    { 
                        var driverLicenses = await _repository.DriverLicense.GetDriverLicensesByDriverAsync(driver.DriverId, trackChanges: false);
                        if (!driverLicenses.Any())
                        {
                            driver.DriverLicenses = driverLicenses.ToList();
                        }
                    }
                }

                var driversDto = _mapper.Map<IEnumerable<DriverDto>>(driversDb);

                return Ok(new
                {
                    data = driversDto,
                    pagination = driversDb.MetaData
                });
                
            }
            catch (Exception ex)
            {
                _logger.LogError($"Hubo un error al tratar de realizar la busqueda de conductores, aca el detalle: {ex.Message}");
                return BadRequest("Hubo un error al tratar de realizar la busqueda de conductores");
            }
        }

        [HttpGet("GetDrivers/All")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetDriversAll()
        {
            try
            {
                var currentUserDto = await GetUserInfoFromToken();
                var driversDb = await _service.Driver.GetAllDriversAsync(currentUserDto.Ruc, currentUserDto.Roles[0] == "Administrator", trackChanges: false);
                var driversDto = _mapper.Map<IEnumerable<DriverDto>>(driversDb);

                return Ok(driversDto);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Hubo un error al tratar de realizar la busqueda de Conductores (All), aca el detalle: {ex.Message}");
                return BadRequest("Hubo un error al tratar de realizar la busqueda de Conductores (All)");
            }
        }

        [HttpGet("collection({ids})", Name = "DriversCollection")]
        public async Task<IActionResult> GetDriverCollection(
            [ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
        {
            if (ids == null)
            {
                _logger.LogError("Parametro ids es nulo");
                return BadRequest("Parametro ids es nulo");
            }

            var driverEntities = await _service.Driver.GetByIdsAsync(ids, trackChanges: false);

            if (ids.Count() != driverEntities.Count()) {
                _logger.LogError("Algunos de los Ids de la coleccion no son validos");
                return NotFound();
            }

            var driversToReturn = _mapper.Map<IEnumerable<DriverDto>>(driverEntities);
            return Ok(driversToReturn);
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateDriver(Guid id, [FromBody] DriverForUpdateDto driverDto)
        {
            try
            {
                var driverDb = _service.Driver.GetDriverByIdAsync(id, trackChanges: false);
                if (driverDb == null)
                {
                    _logger.LogInfo($"El conductor con id: {id} no existe en la base de datos.");
                    return NotFound();
                }

                _mapper.Map(driverDto, driverDb);

                await _repository.SaveAsync();

                return NoContent();

            }
            catch (Exception ex)
            {
                _logger.LogError($"Hubo un error al tratar de actualizar los datos del conductor, aca el detalle: {ex.Message}");
                return BadRequest("Hubo un error en la ejecucion del metodo");
            }
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> DeleteDriver(Guid id)
        {
            try
            {
                var driverDb = await _service.Driver.GetDriverByIdAsync(id, trackChanges: false);
                if (driverDb == null)
                {
                    _logger.LogInfo($"El conductor con id: {id} no existe en la base de datos.");
                    return NotFound();
                }

                _service.Driver.DeleteDriver(driverDb);
                await _repository.SaveAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Hubo un error al tratar de eliminar al conductor con id: {id}, aca el detalle: {ex.Message}");
                return BadRequest($"Hubo un error al tratar de eliminar al conductor con id: {id}");
            }
        }


        #endregion

        #region Private Methods
        private async Task<UserDto> GetUserInfoFromToken()
        {
            UserDto userDto = new UserDto();

            // Acceder al encabezado "x-token" desde HttpContext
            if (HttpContext.Request.Headers.TryGetValue("x-token", out var tokenHeaderValue))
            {
                string token = tokenHeaderValue.ToString();
                if (token != null)
                {
                    List<ClaimMetadata> claims = await _authManager.GetClaimsAsync(token);
                    if (claims.Count() > 0)
                    {
                        string? uid = claims.Find(x => x.Type == "Id")?.Value;
                        // var renewToken = _authManager.RenewTokenAsync(uid.ToString());
                        var userDB = await _userManager.FindByIdAsync(uid.ToString());

                        // var userDto = _mapper.Map<UserDto>(renewToken.Result.User);
                        //_mapper.Map(renewToken.Result.User, userDto);
                        _mapper.Map(userDB, userDto);
                        userDto.Roles = userDto.Roles = _userManager.GetRolesAsync(new User
                        {
                            Id = userDto.Id,
                            FirstName = userDto.FirstName,
                            LastName = userDto.LastName,
                            Email = userDto.Email,
                            UserName = userDto.UserName
                        }).Result.ToList();

                        Company company = await _repository.UserCompany.GetCompanyByUserIdAsync(uid, false);
                        userDto.Ruc = company.Ruc;

                        UserDetail userDetail = await _repository.UserDetail.GetUserDetailByUserIdAsync(uid, false);
                        userDto.UserDetail = userDetail;
                    }
                }
            }

            return userDto;
        }
        #endregion
    }
}
