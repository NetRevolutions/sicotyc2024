export interface ICompany {
    companyId: string,
    ruc: string,
    companyName: string,
    companyComercialName: string,
    companyState: string,
    companyCondition: string,
    companyFiscalAddress: string,
    companyEmail: string,
    companyPhone: string
};

export interface ICompanyForRegistration {
    ruc: string,
    companyName: string,
    companyComercialName: string,
    companyState: string,
    createdBy: string
};

export interface ICompanyForUpdate {
    companyId: string,
    companyName: string,
    companyComercialName: string,
    updatedBy: string
};