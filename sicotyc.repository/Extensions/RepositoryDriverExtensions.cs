using sicotyc.entities.Models;
using sicotyc.repository.Extensions.Utility;
using System.Linq.Dynamic.Core;

namespace sicotyc.repository.Extensions
{
    public static class RepositoryDriverExtensions
    {
        public static IQueryable<Driver> Search(this IQueryable<Driver> drivers, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return drivers;

            var lowerCaseTerm = searchTerm.Trim().ToLower();

            return drivers.Where(d => d.DocumentNumber.Contains(lowerCaseTerm) ||
                            d.Address.Contains(lowerCaseTerm) ||
                            d.DocumentNumber.Contains(lowerCaseTerm) ||
                            d.DocumentType.Contains(lowerCaseTerm) ||
                            d.FirstName.Contains(lowerCaseTerm) ||
                            d.LastName.Contains(lowerCaseTerm));
        }

        public static IQueryable<Driver> Sort(this IQueryable<Driver> drivers, string orderByQueryString)
        {
            if (string.IsNullOrEmpty(orderByQueryString))
                return drivers.OrderBy(d => d.LastName);

            var orderQuery = OrderQueryBuilder.CreateOrderQuery<Driver>(orderByQueryString);

            if (string.IsNullOrEmpty(orderQuery))
                return drivers.OrderBy(d => d.LastName);

            return drivers.OrderBy(orderQuery);
        }
    }
}
