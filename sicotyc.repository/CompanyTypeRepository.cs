using Microsoft.EntityFrameworkCore;
using sicotyc.contracts;
using sicotyc.entities.Models;

namespace sicotyc.repository
{
    public class CompanyTypeRepository: RepositoryBase<CompanyType>, ICompanyTypeRepository
    {
        public CompanyTypeRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {                
        }

        public async Task<List<string>> GetCompanyTypesByRuc(string ruc, bool trackChanges)
        {
            return await FindByCondition(c => c.Ruc.Equals(ruc), trackChanges)
                .Select(s => s.LookupCodeValue)
                .ToListAsync();
        }

        public async Task<List<CompanyType>> GetAllCompanyTypes()
        { 
            return await FindAll(false).ToListAsync();
        }

        public void CreateCompanyType(CompanyType companyType) => Create(companyType);

        public void DeleteCompanyType(CompanyType companyType) => Delete(companyType);

        public async Task DeleteAllCompanyTypeByRuc(string ruc, bool trackChanges)
        {
            List<string> companyTypes = await GetCompanyTypesByRuc(ruc, trackChanges);

            foreach (var companyType in companyTypes)
            {
                CompanyType ct = new CompanyType()
                {
                    Ruc = ruc,
                    LookupCodeValue = companyType
                };

                DeleteCompanyType(ct);
            }
        }


        
    }
}
