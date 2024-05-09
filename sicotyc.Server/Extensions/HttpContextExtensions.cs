using Microsoft.EntityFrameworkCore;

namespace sicotyc.Server.Extensions
{
    public static class HttpContextExtensions
    {
        public async static Task InsertPaginationParamsHeader<T>(this HttpContext httpContext,
            IQueryable<T> queryable)
        {
            if (httpContext == null) throw new ArgumentNullException(nameof(httpContext));

            double count = await queryable.CountAsync();
            httpContext.Response.Headers.Add("countTotalRegisters", count.ToString());
        }
    }
}
