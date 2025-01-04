namespace sicotyc.contracts
{
    public interface IRepositoryManager
    {
        IAuthenticationManager AuthenticationManager { get; }
        ILookupCodeGroupRepository LookupCodeGroup { get; }
        ILookupCodeRepository LookupCode { get; }
        ICompanyRepository Company { get; }
        IUserCompanyRepository UserCompany { get; }
        IUserDetailRepository UserDetail { get; }
        IDriverRepository Driver { get; }
        IDriverLicenseRepository DriverLicense { get; }
        IUnitTransportRepository UnitTransport { get; }
        IRepositoryStoreProcedure RepositoryStoreProcedure { get; }        
        Task SaveAsync();        
    }
}
