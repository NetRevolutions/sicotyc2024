using sicotyc.entities.Models;

namespace sicotyc.contracts
{
    public interface IRepositoryStoreProcedure
    {
        Task<List<OptionByRole>> GetMenuOptionsByRoleAsync(string roleName);
        Task<List<MenuOptionRole>> UpdateOptionRoleAsync(string roleName, string optionIds);
    }
}
