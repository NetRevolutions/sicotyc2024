using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using sicotyc.contracts;
using sicotyc.entities.Models;

namespace sicotyc.repository
{
    public class RepositoryStoreProcedure : IRepositoryStoreProcedure
    {
        private readonly RepositoryContext _repositoryContext;

        public RepositoryStoreProcedure(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public async Task<List<OptionByRole>> GetMenuOptionsByRoleAsync(string roleName)
        {
            var paramRoleName = new SqlParameter("@ROLE_NAME", roleName);

            return await _repositoryContext.Set<OptionByRole>()
                .FromSqlRaw("EXEC [SCT].[USP_GET_MENU_OPTIONS_BY_ROLE] @ROLE_NAME", paramRoleName)
                .ToListAsync();
        }

        public async Task<List<MenuOptionRole>> UpdateOptionRoleAsync(string roleName, string optionIds)
        {
            var paramRoleName = new SqlParameter("@roleName", roleName);
            var paramOptionIds = new SqlParameter("@strOptionIds", optionIds);

            return await _repositoryContext.Set<MenuOptionRole>()
                .FromSqlRaw("EXEC [SCT].[USP_ASSIGN_MENU_OPTIONS] @roleName, @strOptionIds", paramRoleName, paramOptionIds)
                .ToListAsync();
        }
    }
}
