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
    [Route("api/company")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IAuthenticationManager _authManager;
        private readonly IRepositoryManager _repository;
        private readonly IConfiguration _configuration;

        public CompanyController(ILoggerManager logger,
            IMapper mapper,
            UserManager<User> userManager,
            RoleManager<Role> roleManager,
            IAuthenticationManager authManager,
            IRepositoryManager repository,
            IConfiguration configuration)
        { 
            _authManager = authManager;
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _repository = repository;
            _configuration = configuration;
        }

        #region CRUD company
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterCompany([FromBody] CompanyForRegistrationDto companyForRegistration)
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
                    var companyEntity = _mapper.Map<Company>(companyForRegistration);
                    var claims = await _repository.AuthenticationManager.GetClaimsAsync(tokenHeaderValue.ToString());
                    companyEntity.CreatedBy = claims.Count() > 0 ? claims.Find(x => x.Type == "Id").Value : "system";

                    _repository.Company.CreateCompany(companyEntity);
                    await _repository.SaveAsync();

                    var companyToReturn = _mapper.Map<CompanyForRegistrationDto>(companyEntity);

                    return CreatedAtRoute("CompanyByRuc", new { ruc = companyToReturn.Ruc }, companyToReturn);
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Hubo un error al tratar de crear el Company aca el detalle: {ex.Message}");
                    return BadRequest("Hubo un error en la ejecucion del metodo");
                }
            }
            else
            {
                return BadRequest("No hay token en la peticion");
            }
        }

        [HttpGet("ruc/{ruc}", Name = "CompanyByRuc")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetCompany(string ruc)
        {
            var company = await _repository.Company.GetCompanyByRucAsync(ruc, trackChanges: false);

            if (company == null)
            {
                _logger.LogError($"La empresa con ruc {ruc} no existe en la base de datos.");
                return NotFound();
            }
            else { 
                var companyDto = _mapper.Map<CompanyDto>(company);
                return Ok(companyDto);
            }
        }

        [HttpGet("{companyId:guid}", Name = "CompanyById")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetCompanyById(Guid companyId)
        {
            var company = await _repository.Company.GetCompanyByIdAsync(companyId, trackChanges: false);

            if (company == null)
            {
                _logger.LogError($"La empresa con id {companyId} no existe en la base de datos.");
                return NotFound();
            }
            else
            {
                var companyDto = _mapper.Map<CompanyDto>(company);
                return Ok(companyDto);
            }
        }

        [HttpGet("GetCompanies")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetCompanies([FromQuery] CompanyParameters companyParameters)
        {
            try
            {
                var companiesDb = await _repository.Company.GetAllCompaniesAsync(companyParameters, trackChanges: false);

                var companiesDto = _mapper.Map<IEnumerable<CompanyDto>>(companiesDb);

                return Ok(new { 
                    data = companiesDto,
                    pagination = companiesDb.MetaData
                });

            }
            catch (Exception ex)
            {
                _logger.LogError($"Hubo un error al tratar de realizar la busqueda de Empresas, aca el detalle: {ex.Message}");
                return BadRequest("Hubo un error al tratar de realizar la busqueda de Empresas");
            }
        }

        [HttpGet("GetCompanies/All")] //without pagination
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> GetCompaniesAll()
        {
            try
            {
                var companiesDb = await _repository.Company.GetAllCompaniesAsync(trackChanges: false);
                var companiesDto = _mapper.Map<IEnumerable<CompanyDto>>(companiesDb);

                return Ok(companiesDto);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Hubo un error al tratar de realizar la busqueda de Empresas (All), aca el detalle: {ex.Message}");
                return BadRequest("Hubo un error al tratar de realizar la busqueda de Empresas (All)");
            }
        }

        [HttpGet("collection({ids})", Name = "CompanyCollection")]
        public async Task<IActionResult> GetCompanyCollection(
            [ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
        {
            if (ids == null)
            {
                _logger.LogError("Parametro ids es nulo");
                return BadRequest("Parametro ids es nulo");
            }

            var companyEntities = await _repository.Company.GetByIdsAsync(ids, trackChanges: false);

            if (ids.Count() != companyEntities.Count()) {
                _logger.LogError("Algunos de los Ids de la coleccion no son validos");
                return NotFound();
            }

            var companiesToReturn = _mapper.Map<IEnumerable<CompanyDto>>(companyEntities);
            return Ok(companiesToReturn);
        }


        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateCompany(Guid id, [FromBody] CompanyForUpdateDto companyDto)
        {
            try
            {
                var companyDB = await _repository.Company.GetCompanyByIdAsync(id, trackChanges: true);
                if (companyDB == null)
                {
                    _logger.LogInfo($"La empresa con id: {id} no existe en la base de datos.");
                    return NotFound();
                }                
                
                _mapper.Map(companyDto, companyDB);


                await _repository.SaveAsync();

                return NoContent();

            }
            catch (Exception ex)
            {
                _logger.LogError($"Hubo un error al tratar de actualizar los datos de la empresa, aca el detalle: {ex.Message}");
                return BadRequest("Hubo un error en la ejecucion del metodo");
            }
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> DeleteCompany(Guid id)
        {
            try
            {
                var companyDB = await _repository.Company.GetCompanyByIdAsync(id, trackChanges: false);
                if (companyDB == null)
                {
                    _logger.LogInfo($"La empresa con id: {id} no existe en la base de datos.");
                    return NotFound();
                }

                _repository.Company.DeleteCompany(companyDB);
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