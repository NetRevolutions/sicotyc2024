using sicotyc.entities.Models;

namespace sicotyc.contracts
{
    public interface IUserCompanyRepository
    {
        Task<bool> ExistUserCompanyAsync(UserCompany userCompany, bool trackChanges);
        Task<List<Guid>> GetUserIdsByCompanyId(Guid companyId, bool trackChanges);
        Task<Guid> GetCompanyIdByUserIdAsync(Guid userId, bool trackChanges);
        Task<Guid> GetUserIdByCompanyIdAsync(Guid companyId, bool trackChanges);
        Task<Company> GetCompanyByUserIdAsync(Guid userId, bool trackChanges);

        void CreateUserCompany(UserCompany userCompany);
        void DeleteUserCompany(UserCompany userCompany);
        Task<List<Company>> GetAllCompanyIdsByUserIdAsync(Guid userId, bool trackChanges);
        Task DeleteAllCompaniesAssociatedUserAsync(Guid userId, bool trackChanges);

    }
}
