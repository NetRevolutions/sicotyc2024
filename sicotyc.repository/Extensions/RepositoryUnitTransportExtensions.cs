using sicotyc.entities.Models;
using sicotyc.repository.Extensions.Utility;
using System.Linq.Dynamic.Core;

namespace sicotyc.repository.Extensions
{
    public static class RepositoryUnitTransportExtensions
    {
        public static IQueryable<UnitTransport> Search(this IQueryable<UnitTransport> unitTransports, string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm)) 
                return unitTransports;

            var lowerCaseTerm = searchTerm.Trim().ToLower();

            return unitTransports.Where(u => u.Plate.ToLower().Contains(lowerCaseTerm) ||
                                    u.Brand.ToLower().Contains(lowerCaseTerm));
        }

        public static IQueryable<UnitTransport> Sort(this IQueryable<UnitTransport> unitTransports, string orderByQueryString)
        { 
            if (string.IsNullOrEmpty(orderByQueryString))
                return unitTransports.OrderBy(u => u.Plate);

            var orderQuery = OrderQueryBuilder.CreateOrderQuery<UnitTransport>(orderByQueryString);

            if (string.IsNullOrEmpty(orderQuery))
                return unitTransports.OrderBy(u => u.Plate);

            return unitTransports.OrderBy(orderQuery);
        }
    }
}
