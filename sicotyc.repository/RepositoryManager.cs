using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using sicotyc.contracts;
using sicotyc.entities.Models;

namespace sicotyc.repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {       
        private readonly RepositoryContext _repositoryContext;       

        private readonly Lazy<IAuthenticationManager> _authenticationManager;
        private readonly Lazy<ILookupCodeGroupRepository> _lookupCodeGroupRepository;
        private readonly Lazy<ILookupCodeRepository> _lookupCodeRepository;
        private readonly Lazy<ICompanyRepository> _companyRepository;
        private readonly Lazy<ICompanyTypeRepository> _companyTypeRepository;
        private readonly Lazy<IUserCompanyRepository> _userCompanyRepository;
        private readonly Lazy<IUserDetailRepository> _userDetailRepository;
        private readonly Lazy<IDriverLicenseRepository> _driverLicenseRepository;
        private readonly Lazy<IDriverRepository> _driverRepository;
        private readonly Lazy<IUnitTransportRepository> _unitTransportRepository;
        private readonly Lazy<IRepositoryStoreProcedure> _repositoryStoreProcedure;
        

        public RepositoryManager(UserManager<User> userManager, IConfiguration configuration, RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;

            _authenticationManager = new Lazy<IAuthenticationManager>(() => new AuthenticationManager(userManager, configuration, repositoryContext));
            _lookupCodeGroupRepository = new Lazy<ILookupCodeGroupRepository>(() => new LookupCodeGroupRepository(repositoryContext));
            _lookupCodeRepository = new Lazy<ILookupCodeRepository>(() => new LookupCodeRepository(repositoryContext));
            _companyRepository = new Lazy<ICompanyRepository>(() => new CompanyRepository(repositoryContext));
            _companyTypeRepository = new Lazy<ICompanyTypeRepository>(() => new CompanyTypeRepository(repositoryContext));
            _userCompanyRepository = new Lazy<IUserCompanyRepository>(() => new UserCompanyRepository(repositoryContext));
            _userDetailRepository = new Lazy<IUserDetailRepository>(() => new UserDetailRepository(repositoryContext));
            _driverLicenseRepository = new Lazy<IDriverLicenseRepository>(() => new DriverLicenseRepository(repositoryContext));
            _driverRepository = new Lazy<IDriverRepository>(() => new DriverRepository(repositoryContext));
            _unitTransportRepository = new Lazy<IUnitTransportRepository>(() => new UnitTransportRepository(repositoryContext));
            _repositoryStoreProcedure = new Lazy<IRepositoryStoreProcedure>(() => new RepositoryStoreProcedure(repositoryContext));            
        }
        public IAuthenticationManager AuthenticationManager => _authenticationManager.Value;
        public ILookupCodeGroupRepository LookupCodeGroup => _lookupCodeGroupRepository.Value;
        public ILookupCodeRepository LookupCode => _lookupCodeRepository.Value;
        public ICompanyRepository Company => _companyRepository.Value;
        public ICompanyTypeRepository CompanyType => _companyTypeRepository.Value;
        public IUserCompanyRepository UserCompany => _userCompanyRepository.Value;
        public IUserDetailRepository UserDetail => _userDetailRepository.Value;
        public IDriverLicenseRepository DriverLicense => _driverLicenseRepository.Value;
        public IDriverRepository Driver => _driverRepository.Value;
        public IUnitTransportRepository UnitTransport => _unitTransportRepository.Value;
        public IRepositoryStoreProcedure RepositoryStoreProcedure => _repositoryStoreProcedure.Value;

        public Task SaveAsync() => _repositoryContext.SaveChangesAsync();
    }
}
