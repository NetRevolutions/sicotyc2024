import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment';
import { catchError, map, throwError } from 'rxjs';

// Interfaces
import { ICompany, ICompanyForRegistration, ICompanyForUpdate } from '../interfaces/company.interface';
import { IPagination } from '../interfaces/pagination.interface';

// Services
import { UserService } from './user.service';
import { ValidationErrorsCustomizeService } from './validation-errors-customize.service';


const base_url = environment.base_url;

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  constructor(
    private http: HttpClient,
    private router: Router,
    private userService: UserService,
    private validationErrorsCustomize: ValidationErrorsCustomizeService
  ) { }

  get token(): string {

    return localStorage.getItem('token') || '';
  };

  get headers() {
    return {
      headers: {
        'x-token': this.token
      }
    }
  };

  //#region CRUD
  createCompany(formData: ICompanyForRegistration) {
    var claims = this.userService.getClaimsFromLocalStorage(); 
    var userId = claims.find(f => f.type == 'Id').value.toString();

    const data = {
      ...formData, 
      createdBy: userId 
    };

    return this.http.post(`${ base_url }/company`, data, this.headers)
    .pipe(
      catchError(error => {
        return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
      })       
    );
  };


  updateCompany(formData: ICompanyForUpdate) {
    var claims = this.userService.getClaimsFromLocalStorage(); 
    var userId = claims.find(f => f.type == 'Id').value.toString();  
    const data = {
      ...formData,
      
      updatedBy: userId
    };

    return this.http.put(`${ base_url }/company/${formData.companyId}`, data, this.headers)
    .pipe(
      catchError(error => {
        return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
      })   
    );
  };

  getCompanies(pagination: IPagination, searchTerm: string = '') {
    const url = `${ base_url }/company/getCompanies?pageNumber=${pagination.pageNumber}&pageSize=${pagination.pageSize}&searchTerm=${searchTerm}`;
    return this.http.get(url)
      .pipe(
        map((resp:any) => {
          let companies: ICompany[] = resp.data;

          return {
            data: companies,
            pagination: resp.pagination
          }
        }),
        catchError(error => {
          return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
        })
      );
  };

  getCompaniesByIdCollection(ids: string[]) {
    const url = `${ base_url }/company/collection(${ids.join(',')})`;
    return this.http.get(url)
    .pipe(
      map((resp: any) => {
        let companies: ICompany[] = resp.map((c: any) => ({
          companyId: c.companyId,
          ruc: c.ruc,
          companyName: c.companyName,
          companyComercialName: c.companyComercialName,
          companyState: c.companyState,
          companyCondition: c.companyCondition,
          companyFiscalAddress: c.companyFiscalAddress,
          companyEmail: c.companyEmail,
          companyPhone: c.companyPhone
        }));
        return {
          data: companies
        }
      }),
      catchError(error => {
        return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
      })
    )
  };

  getAllCompanies() {
    const url = `${ base_url }/company/getCompanies/All`;
    return this.http.get(url)
      .pipe(
        map((resp:any) => {
          let companies: ICompany[] = resp.data;

          return {
            data: companies
          }
        }),
        catchError(error => {
          return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
        })
      );
  };

  getCompanyById(companyId: string) {
    const url = `${ base_url }/company/${companyId}`;
    return this.http.get(url)
      .pipe(
        map((resp:any) => {
          let company: ICompany = resp;

          return {
            data: company
          }
        }),
        catchError(error => {
          return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
        })
      );
  };

  getCompanyByRuc(ruc: string) {
    const url = `${ base_url }/company/ruc/${ruc}`;
    return this.http.get(url)
      .pipe(
        map((resp:any) => {
          let company: ICompany = resp.data;

          return {
            data: company
          }
        }),
        catchError(error => {
          return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
        })
      );
  };

  deleteCompany(id: string) {
    const url = `${ base_url }/company/${id}`;
    return this.http.delete(url, this.headers);
  };

  //#endregion
}
