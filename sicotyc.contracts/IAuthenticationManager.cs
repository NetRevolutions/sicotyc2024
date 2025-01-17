using sicotyc.entities.DataTransferObjects;
using sicotyc.entities.Models;
using sicotyc.entities.RequestFeatures;

namespace sicotyc.contracts
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
        Task<User> FindUserByEmailAsync(string email, bool trackChanges);
        Task<User> FindUserByUserNameAsync(string userName, bool trackChanges);
        Task<string> CreateTokenAsync();
        Task<RenewToken> RenewTokenAsync(string userId);
        Task<ResultProcess> ValidateToken(string token);
        Task<PagedList<User>> GetUsersAsync(UserParameters userParameters, bool trackChanges);
        Task<List<User>> GetUsersByIdCollectionAsync(IEnumerable<Guid> ids, bool trackChanges);
        Task<List<ClaimMetadata>> GetClaimsAsync(string token);
    }
}
