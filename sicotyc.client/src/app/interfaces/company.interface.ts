import { SafeHtml } from "@angular/platform-browser"

export interface ICompany {
    companyId: string,
    ruc: string,
    companyName: string,
    companyComercialName: string,
    companyState: string,
    companyCondition: string,
    companyFiscalAddress: string,
    companyEmail: string,
    companyPhone: string,
    companyTypes: string[],
    companyTypesHtml: string | SafeHtml // Permitir ambos tipos;
};

export interface ICompanyForRegistration {
    ruc: string,
    companyName: string,
    companyComercialName: string,
    companyState: string,
    companyTypes: string[],
    createdBy: string
};

export interface ICompanyForUpdate {
    companyId: string,
    companyName: string,
    companyComercialName: string,
    companyEmail: string,
    companyPhone: string,
    companyTypes: string[],
    updatedBy: string
};

export interface ICompanyType {
    ruc: string,
    typeOfCompany: string
}