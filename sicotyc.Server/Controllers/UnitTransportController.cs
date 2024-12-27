using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using sicotyc.contracts;
using sicotyc.entities.DataTransferObjects;
using sicotyc.entities.Models;
using sicotyc.entities.RequestFeatures;
using sicotyc.Server.ActionFilters;
using sicotyc.Server.ModelBinders;

namespace sicotyc.Server.Controllers
{
    [Route("api/unit-transport")]
    [ApiController]
    public class UnitTransportController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IAuthenticationManager _authManager;
        private readonly IRepositoryManager _repository;
        private readonly IConfiguration _configuration;

        public UnitTransportController(ILoggerManager logger,
            IMapper mapper,
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager,
            IAuthenticationManager authManager,
            IRepositoryManager repository,
            IConfiguration configuration
            )
        {
            _authManager = authManager;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _repository = repository;
            _configuration = configuration;
        }

        #region CRUD Unit Transport
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUnitTransport([FromBody] UnitTransportForRegistrationDto unitTransportForRegistration)
        {
            // Acceder al encabezado "x-token" desde HttpContext
            if (HttpContext.Request.Headers.TryGetValue("x-token", out var tokenHeaderValue))
            {
                // Implementamos validacion del token
                var resultValidateToken = _authManager.ValidateToken(tokenHeaderValue).Result;
                if (!resultValidateToken.Success)
                {
                    return Unauthorized(resultValidateToken.Message);
                }

                try
                {
                    //if (unitTransportForRegistration.UnitTransportDetail.UnitTransportDetailId == Guid.Parse("00000000-0000-0000-0000-000000000000"))
                    unitTransportForRegistration.UnitTransportDetail.UnitTransportDetailId = Guid.NewGuid();
                    unitTransportForRegistration.UnitTransportDetail.UnitTransportId = unitTransportForRegistration.UnitTransportId;

                    var unitTransportEntity = _mapper.Map<UnitTransport>(unitTransportForRegistration);
                    var claims = await _repository.AuthenticationManager.GetClaimsAsync(tokenHeaderValue.ToString());
                    unitTransportEntity.CreatedBy = claims.Count() > 0 ? claims.Find(x => x.Type == "Id").Value : "system";

                    _repository.UnitTransport.CreateUnitTransport(unitTransportEntity);
                    await _repository.SaveAsync();

                    var unitTransportToReturn = _mapper.Map<UnitTransportForRegistrationDto>(unitTransportEntity);

                    return CreatedAtRoute("UnitTransportById", new { id = unitTransportToReturn.UnitTransportId }, unitTransportToReturn);

                }
                catch (Exception ex)
                {
                    _logger.LogError($"Hubo un error al tratar de crear la Unidad de Transporte aca el detalle: {ex.Message}");
                    return BadRequest("Hubo un error en la ejecucion del metodo");
                }
            }
            else
            {
                return BadRequest("No hay token en la peticion");
            }
        }

        [HttpGet("{id:guid}", Name = "UnitTransportById")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetUnitTransportById(Guid id)
        {
            var unitTransport = await _repository.UnitTransport.GetUnitTransportByIdAsync(id, trackChanges: false);

            if (unitTransport == null)
            {
                _logger.LogError($"La unidad de transporte con id {id} no existe en la base de datos.");
                return NotFound();
            }
            else {
                var unitTransportDto = _mapper.Map<UnitTransportDto>(unitTransport);
                return Ok(unitTransportDto);    
            }
        }

        [HttpGet("plate/{plate}", Name = "UnitTransportByPlate")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetUnitTransportByPlate(string plate)
        {
            var unitTransport = await _repository.UnitTransport.GetUnitTransportByPlateAsync(plate, trackChanges: false);

            if (unitTransport == null)
            {
                //_logger.LogError($"La unidad de transporte con placa {plate} no existe en la base de datos.");
                //return NotFound();
                return NoContent();
            }
            else
            {
                var unitTransportDto = _mapper.Map<UnitTransportDto>(unitTransport);
                return Ok(unitTransportDto);
            }
        }

        [HttpGet("GetUnitTransports")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetUnitTransports([FromQuery] UnitTransportParameters parameters)
        {
            try
            {
                var unitTransportsDb = await _repository.UnitTransport.GetAllUnitTransportsAsync(parameters, trackChanges: false);

                var unitTransportsDto = _mapper.Map<IEnumerable<UnitTransportDto>>(unitTransportsDb);

                return Ok(new { 
                    data = unitTransportsDto,
                    pagination = unitTransportsDb.MetaData
                });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Hubo un error al tratar de realizar la busqueda de Unidades de Transporte, aca el detalle: {ex.Message}");
                return BadRequest("Hubo un error al tratar de realizar la busqueda de Unidades de Transporte");
            }
        }

        [HttpGet("GetUnitTransports/All")] //without pagination
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetUnitTransportsAll()
        {
            try
            {
                var unitTransportsDb = await _repository.UnitTransport.GetAllUnitTransportsAsync(trackChanges: false);

                var unitTransportsDto = _mapper.Map<IEnumerable<UnitTransportDto>>(unitTransportsDb);

                return Ok(unitTransportsDto);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Hubo un error al tratar de realizar la busqueda de Unidades de Transporte (All), aca el detalle: {ex.Message}");
                return BadRequest("Hubo un error al tratar de realizar la busqueda de Unidades de Transporte (All)");
            }
        }

        [HttpGet("collection({ids})", Name = "UnitTransportCollection")]
        public async Task<IActionResult> GetUniTransportCollection(
            [ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
        {
            if (ids == null)
            {
                _logger.LogError("Parametro ids es nulo");
                return BadRequest("Parametro ids es nulo");
            }

            var entities = await _repository.UnitTransport.GetByIdsAsync(ids, trackChanges: false);
            
            if (ids.Count() != entities.Count()) 
            {
                _logger.LogError("Algunos de los Ids de la coleccion no son validos");
                return NotFound();
            }

            var unitTransportsToReturn = _mapper.Map<UnitTransportDto>(entities);
            return Ok(unitTransportsToReturn);
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateUnitTransport(Guid id, [FromBody] UnitTransportForUpdateDto unitTransportDto)
        {
            try
            {
                var unitTransportDb = await _repository.UnitTransport.GetUnitTransportByIdAsync(id, trackChanges: true);
                if (unitTransportDb == null)
                {
                    _logger.LogInfo($"La unidad de transporte con id: {id} no existe en la base de datos.");
                    return NotFound();
                }

                _mapper.Map(unitTransportDto, unitTransportDb);

                await _repository.SaveAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Hubo un error al tratar de actualizar los datos de la unidad de transporte, aca el detalle: {ex.Message}");
                return BadRequest("Hubo un error en la ejecucion del metodo");
            }
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> DeleteUnitTransport(Guid id)
        {
            try
            {
                var unitTransportDb = await _repository.UnitTransport.GetUnitTransportByIdAsync(id, trackChanges : false);
                if (unitTransportDb == null)
                {
                    _logger.LogInfo($"La unidad de transporte con id: {id} no existe en la base de datos.");
                    return NotFound();
                }

                _repository.UnitTransport.DeleteUnitTransport(unitTransportDb);
                await _repository.SaveAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Hubo un error al tratar de eliminar la empresa con id: {id}, aca el detalle: {ex.Message}");
                return BadRequest($"Hubo un error al tratar de eliminar la empresa con id: {id}");
            }
        }

        #endregion

        #region Private Methods



        #endregion
    }
}
