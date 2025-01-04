using Microsoft.EntityFrameworkCore;
using sicotyc.contracts;
using sicotyc.entities.Models;

namespace sicotyc.repository
{
    public class UserCompanyRepository : RepositoryBase<UserCompany>, IUserCompanyRepository
    {
        public UserCompanyRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<bool> ExistUserCompanyAsync(UserCompany userCompany, bool trackChanges)
        {
            //return await FindByCondition(o => o.Id!.Equals(userCompany.Id) && o.CompanyId.Equals(userCompany.CompanyId), trackChanges)
            //    .AnyAsync();
            return await FindByCondition(o => o.Id!.Equals(userCompany.Id) && o.Ruc.Equals(userCompany.Ruc), trackChanges)
                .AnyAsync();
        }

        //public async Task<Guid> GetCompanyIdByUserIdAsync(Guid userId, bool trackChanges)
        //{
        //    return await FindByCondition(o => o.Id.Equals(userId), trackChanges)
        //        .Select(s => s.CompanyId)
        //        .FirstOrDefaultAsync();

        //}

        public async Task<string> GetCompanyRucByUserIdAsync(Guid userId, bool trackChanges)
        {
            return await FindByCondition(o => o.Id.Equals(userId), trackChanges)
                .Select(c => c.Ruc)
                .FirstOrDefaultAsync();
        }

        //public async Task<Guid> GetUserIdByCompanyIdAsync(Guid companyId, bool trackChanges)
        //{
        //    return await FindByCondition(o => o.CompanyId.Equals(companyId), trackChanges)
        //        .Select(s => s.Id)
        //        .FirstOrDefaultAsync();
        //}

        public async Task<Guid> GetUserIdByCompanyRucAsync(string ruc, bool trackChanges)
        { 
            return await FindByCondition(o => o.Ruc.Equals(ruc), trackChanges)
                .Select(u => u.Id)
                .FirstOrDefaultAsync();
        }

        public async Task<Company> GetCompanyByUserIdAsync(Guid userId, bool trackChanges)
        {
            return await FindByCondition(o => o.Id.Equals(userId), trackChanges)
                .Select(s => s.Company)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Company>> GetAllCompanyIdsByUserIdAsync(Guid userId, bool trackChanges)
        {
            return await FindByCondition(o => o.Id.Equals(userId), trackChanges)
                .Select(s => s.Company)
                .ToListAsync();
        }

        public void CreateUserCompany(UserCompany userCompany) => Create(userCompany);

        public void DeleteUserCompany(UserCompany userCompany) => Delete(userCompany);

        public async Task DeleteAllCompaniesAssociatedUserAsync(Guid userId, bool trackChanges)
        {
            List<Company> companies = await GetAllCompanyIdsByUserIdAsync(userId, trackChanges);
            foreach (var company in companies)
            {
                UserCompany uc = new UserCompany()
                {
                    Id = userId,
                    Ruc = company.Ruc
                };

                DeleteUserCompany(uc);
            }
        }

        //public async Task<List<Guid>> GetUserIdsByCompanyId(Guid companyId, bool trackChanges)
        //{
        //    return await FindByCondition(o => o.CompanyId.Equals(companyId), trackChanges)
        //         .Select(s => s.Id)
        //         .ToListAsync();
        //}

        public async Task<List<Guid>> GetUserIdsByCompanyRuc(string ruc, bool trackChanges)
        {
            return await FindByCondition(c => c.Ruc.Equals(ruc), trackChanges)
                .Select(u => u.Id)
                .ToListAsync();
        }
    }
}
