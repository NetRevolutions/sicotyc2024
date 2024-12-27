using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using sicotyc.contracts;
using sicotyc.entities.Models;

namespace sicotyc.repository
{
    public class UserDetailRepository : RepositoryBase<UserDetail>, IUserDetailRepository
    {
        public UserDetailRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
        public async Task<bool> ExistsUserDetailAsync(UserDetail userDetail, bool trackChanges)
        {
            return await FindByCondition(ud => ud.User.Id.Equals(userDetail.User.Id), trackChanges)
                .AnyAsync();
        }

        public async Task<UserDetail> GetUserDetailByUserIdAsync(string userId, bool trackChanges)
        {
            return await FindByCondition(ud => ud.User.Id.Equals(userId), trackChanges)
                .FirstOrDefaultAsync();
        }

        public async Task<UserDetail> GetUserDetailByNumDocAsync(string numdoc, bool trackChanges)
        {
            return await FindByCondition(ud => ud.DocumentNumber.Equals(numdoc), trackChanges)
                .FirstOrDefaultAsync();
        }

        public void CreateUserDetail(UserDetail userDetail) => Create(userDetail);

        public void DeleteUserDetail(UserDetail userDetail) => Delete(userDetail);

    }
}
