using sicotyc.entities.DataTransferObjects;

namespace sicotyc.service.contracts
{
    public interface ISearchService
    {
        Task<IEnumerable<SearchResultDto>> SearchAllAsync(string searchTerm);

        Task<IEnumerable<SearchResultDto>> SearchUsersAsync(string searchTerm);
        Task<IEnumerable<SearchResultDto>> SearchLookupCodeGroupsAsync(string searchTerm);
        Task<IEnumerable<SearchResultDto>> SearchLookupCodesAsync(string searchTerm);
        Task<IEnumerable<SearchResultDto>> SearchByCollectionAsync(string collection, string searchTerm);
        Task<IEnumerable<SearchResultDto>> SearchCompaniesAsync(string searchTerm);
    }
}
