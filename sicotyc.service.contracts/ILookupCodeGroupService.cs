using sicotyc.entities.DataTransferObjects;
using sicotyc.entities.RequestFeatures;

namespace sicotyc.service.contracts
{
    public interface ILookupCodeGroupService
    {
        Task<IEnumerable<LookupCodeGroupDto>> GetAllLookupCodeGroupsAsync(LookupCodeGroupParameters lookupCodeGroupParameters, bool trackChanges);
        Task<LookupCodeGroupDto> GetLookupCodeGroupAsync(Guid lookupCodeGroupId, bool trackChanges);
    }
}
