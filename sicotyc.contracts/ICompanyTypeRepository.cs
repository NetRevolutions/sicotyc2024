using sicotyc.entities.Models;

namespace sicotyc.contracts
{
    public interface ICompanyTypeRepository
    {
        Task<List<string>> GetCompanyTypesByRuc(string ruc, bool trackChanges);
        Task<List<CompanyType>> GetAllCompanyTypes();
        void CreateCompanyType(CompanyType companyType);
        void DeleteCompanyType(CompanyType companyType);
        Task DeleteAllCompanyTypeByRuc(string ruc, bool trackChanges);

    }
}
