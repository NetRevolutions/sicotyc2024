﻿using Microsoft.EntityFrameworkCore;
using sicotyc.contracts;
using sicotyc.entities.Models;
using sicotyc.entities.RequestFeatures;
using sicotyc.repository.Extensions;

namespace sicotyc.repository
{
    public class LookupCodeGroupRepository : RepositoryBase<LookupCodeGroup>, ILookupCodeGroupRepository
    {
        public LookupCodeGroupRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<PagedList<LookupCodeGroup>> GetAllLookupCodeGroupsAsync(LookupCodeGroupParameters lookupCodeGroupParameters, bool trackChanges)
        {
            var lookupCodeGroups = await FindByCondition(e => e.Name != string.Empty, trackChanges)
                .Search(lookupCodeGroupParameters.SearchTerm)
                .Sort(lookupCodeGroupParameters.OrderBy)
                .ToListAsync();

            return PagedList<LookupCodeGroup>
                .ToPagedList(lookupCodeGroups, lookupCodeGroupParameters.PageNumber, lookupCodeGroupParameters.PageSize);
        }

        public async Task<IEnumerable<LookupCodeGroup>> GetAllLookupCodeGroupsAsync(bool trackChanges) =>
            await FindByCondition(e => e.Name != string.Empty, trackChanges)
                .Sort("Name")
                .ToListAsync();

        public async Task<bool> ExistsLookupCodeGroupAsync(string lookupCodeGroupName, bool trackChanges)
        {

            var lookupCodeGroups = await GetAllLookupCodeGroupsAsync(trackChanges = false);
            return lookupCodeGroups.Any(f => f.Name.Trim().ToLower() == lookupCodeGroupName.Trim().ToLower());

        }

        public async Task<LookupCodeGroup> GetLookupCodeGroupAsync(Guid lookupCodeGroupId, bool trackChanges) =>
            await FindByCondition(l => l.Id.Equals(lookupCodeGroupId), trackChanges)
            .SingleOrDefaultAsync();

        public async Task<LookupCodeGroup> GetLookupCodeGroupByNameAsync(string name, bool trackChanges) =>
            await FindByCondition(l => l.Name.Trim().ToLower().Equals(name.Trim().ToLower()), trackChanges)
                .SingleOrDefaultAsync();


        public async Task<IEnumerable<LookupCodeGroup>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToListAsync();

        public void CreateLookupCodeGroup(LookupCodeGroup lookupCodeGroup) => Create(lookupCodeGroup);

        public void DeleteLookupCodeGroup(LookupCodeGroup lookupCodeGroup)
        {
            Delete(lookupCodeGroup);
        }


    }
}
