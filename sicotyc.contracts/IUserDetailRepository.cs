using sicotyc.entities.Models;

namespace sicotyc.contracts
{
    public interface IUserDetailRepository
    {
        Task<bool> ExistsUserDetailAsync(UserDetail userDetail, bool trackChanges);
        Task<UserDetail> GetUserDetailByUserIdAsync(Guid userId, bool trackChanges);
        Task<UserDetail> GetUserDetailByNumDocAsync(string numdoc, bool trackChanges);
        void CreateUserDetail(UserDetail userDetail);
        void DeleteUserDetail(UserDetail userDetail);
    }
}
