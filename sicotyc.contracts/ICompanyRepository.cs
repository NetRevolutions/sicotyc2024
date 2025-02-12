﻿using sicotyc.entities.Models;
using sicotyc.entities.RequestFeatures;

namespace sicotyc.contracts
{
    public interface ICompanyRepository
    {
        Task<PagedList<Company>> GetAllCompaniesAsync(CompanyParameters companyParameters, bool trackChanges);
        Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges);
        Task<Company> GetCompanyByIdAsync(Guid id, bool trackChanges);
        Task<Company> GetCompanyByRucAsync(string ruc, bool trackChanges);
        Task<IEnumerable<Company>> GetCompaniesByNameAsync(string searchName, bool trackChanges);
        Task<IEnumerable<Company>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void CreateCompany(Company company);
        void DeleteCompany(Company company);
        void DeleteCompanyByRuc(string ruc);
        
    }
}
