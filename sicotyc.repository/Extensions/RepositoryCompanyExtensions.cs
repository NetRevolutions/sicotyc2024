using sicotyc.entities.Models;
using sicotyc.repository.Extensions.Utility;
using System.Linq.Dynamic.Core;

namespace sicotyc.repository.Extensions
{
    public static class RepositoryCompanyExtensions
    {
        public static IQueryable<Company> Search(this IQueryable<Company> companies, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return companies;

            var lowerCaseTerm = searchTerm.Trim().ToLower();

            return companies.Where(c => c.Ruc.ToLower().Contains(lowerCaseTerm));
        }

        public static IQueryable<Company> Sort(this IQueryable<Company> companies, string orderByQueryString)
        {
            if (string.IsNullOrEmpty(orderByQueryString))
                return companies.OrderBy(c => c.Ruc);

            var orderQuery = OrderQueryBuilder.CreateOrderQuery<Company>(orderByQueryString);

            if (string.IsNullOrEmpty(orderQuery))
                return companies.OrderBy(c => c.Ruc);

            return companies.OrderBy(orderQuery);
        }
    }
}
