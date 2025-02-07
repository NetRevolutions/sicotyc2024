﻿using Microsoft.EntityFrameworkCore;
using sicotyc.contracts;
using sicotyc.entities.Models;
using sicotyc.entities.RequestFeatures;
using sicotyc.repository.Extensions;

namespace sicotyc.repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<PagedList<Company>> GetAllCompaniesAsync(CompanyParameters companyParameters, bool trackChanges)
        {
            var companies = new List<Company>();
            if (!String.IsNullOrEmpty(companyParameters.SearchTerm))
            {
                companies = await FindAll(trackChanges)
                    .Where(c => c.Ruc.Contains(companyParameters.SearchTerm) ||
                            c.CompanyName.Contains(companyParameters.SearchTerm) ||
                            c.CompanyComercialName.Contains(companyParameters.SearchTerm))
                    .OrderBy(o => o.Ruc)
                    .ToListAsync();
                
            }
            else
            {
                companies = await FindByCondition(c => c.Ruc != string.Empty, trackChanges)
                .Search(companyParameters.SearchTerm)
                .Sort(companyParameters.OrderBy)
                .ToListAsync();
            }
            

            return PagedList<Company>
                .ToPagedList(companies, companyParameters.PageNumber, companyParameters.PageSize);
        }

        public async Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges) =>
            await FindByCondition(c => c.Ruc != string.Empty, trackChanges)
            .Sort("CompanyName")
            .ToListAsync();

        public async Task<Company> GetCompanyByIdAsync(Guid id, bool trackChanges) =>
            await FindByCondition(o => o.CompanyId.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        public async Task<IEnumerable<Company>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.CompanyId), trackChanges)
            .ToListAsync();

        public async Task<Company> GetCompanyByRucAsync(string ruc, bool trackChanges) =>
            await FindByCondition(o => o.Ruc.Equals(ruc), trackChanges)
            .SingleOrDefaultAsync();

        public async Task<IEnumerable<Company>> GetCompaniesByNameAsync(string searchName, bool trackChanges)
        {
            var companies = new List<Company>();
            companies = await FindAll(trackChanges)
                .Where(c => c.CompanyName.Contains(searchName) ||
                        c.CompanyComercialName.Contains(searchName))
                .OrderBy(o => o.Ruc)
                .ToListAsync();

            return companies;
        }

        public void CreateCompany(Company company) => Create(company);

        public void DeleteCompany(Company company) => Delete(company);

        public async void DeleteCompanyByRuc(string ruc)
        {
            Company company = await GetCompanyByRucAsync(ruc, false);
            if (company != null)
                DeleteCompany(company);
        }

        
    }
}
