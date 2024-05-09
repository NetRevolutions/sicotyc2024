using sicotyc.entities.DataTransferObjects;
using sicotyc.entities.RequestFeatures;

namespace sicotyc.service.contracts
{
    public interface ILookupCodeService
    {
        Task<IEnumerable<LookupCodeDto>> GetLookupCodesAsync(Guid lookupCodeGroupId, LookupCodeParameters lookupCodeParameters, bool trackChanges);
        Task<LookupCodeDto> GetLookupCodeAsync(Guid lookupCodeGroupId, Guid id, bool trackChanges);
    }
}
