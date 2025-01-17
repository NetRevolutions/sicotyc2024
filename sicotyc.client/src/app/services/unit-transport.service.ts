import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment';
import { catchError, map, throwError } from 'rxjs';

// Interfaces
import { IUnitTransport, IUnitTransportForRegistration, IUnitTransportForUpdate } from '../interfaces/unit-transport.interface';
import { IPagination } from '../interfaces/pagination.interface';

// Services
import { UserService } from './user.service';
import { ValidationErrorsCustomizeService } from './validation-errors-customize.service';

const base_url = environment.base_url;

@Injectable({
  providedIn: 'root'
})
export class UnitTransportService {

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
  createUnitTransport(formData: IUnitTransportForRegistration) {
    var claims = this.userService.getClaimsFromLocalStorage(); 
    var userId = claims.find(f => f.type == 'Id').value.toString();

    const data = {
      ...formData, 
      createdBy: userId 
    };

    console.log('data-unit-transport', data);

    return this.http.post(`${base_url}/unit-transport`, data, this.headers)
    .pipe(
      catchError(error => {
        return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
      })
    );
  };

  updateUnitTransport(formData: IUnitTransportForUpdate) {
    var claims = this.userService.getClaimsFromLocalStorage(); 
    var userId = claims.find(f => f.type == 'Id').value.toString();  
    const data = {
      ...formData,
      
      updatedBy: userId
    };

    return this.http.put(`${base_url}/unit-transport/${formData.unitTransportId}`, data, this.headers)
    .pipe(
      catchError(error => {
        return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
      })
    );
  };

  getUnitTransports(pagination: IPagination, searchTerm: string = '') {
    const url = `${ base_url }/unit-transport/getUnitTransports?pageNumber=${pagination.pageNumber}&pageSize=${pagination.pageSize}&searchTerm=${searchTerm}`;
    return this.http.get(url)
    .pipe(
      map((resp: any) => {
        let unitTransports: IUnitTransport[] = resp.data;

        return {
          data: unitTransports,
          pagination: resp.pagination
        }
      }),
      catchError(error => {
        return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
      })
    );
  };

  getUnitTransportsByIdCollection(ids: string[]) {
    const url = `${ base_url }/unit-transport/collection(${ids.join(',')})`;
    return this.http.get(url)
    .pipe(
      map((resp: any) => {
        let unitTransports: IUnitTransport[] = resp.map((u: any)=> ({
          unitTransportId: u.unitTransportId,
          transportDetail: u.transportDetail,
          plate: u.plate,
          brand: u.brand,
          fabricationYear: u.fabricationYear,
          modelYear: u.modelYear,
          soatExpiredDate: u.soatExpiredDate,
          technicalReviewExpiredDate: u.technicalReviewExpiredDate,
          fuel: u.fuel,
          additionalNotes: u.additionalNotes,
          vehicleQualificationNumber: u.vehicleQualificationNumber,
          vehicleQualificationExpirationDate: u.vehicleQualificationExpirationDate,
          vehicleConfiguration: u.vehicleConfiguration,
          img: u.img
        }));

        return {
          data: unitTransports
        }

      }),
      catchError(error => {
        return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
      })
    )
  };

  getAllUnitTransports() {
    const url = `${ base_url }/unit-transport/getCompanies/All`;
    return this.http.get(url)
    .pipe(
      map((resp: any) => {
        let unitTransports: IUnitTransport[] = resp.data;

        return {
          data: unitTransports
        }
      }),
      catchError(error => {
        return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
      })
    );
  };

  getUnitTransportById(unitTransportId: string) {
    const url = `${ base_url }/unit-transport/${unitTransportId}`;
    return this.http.get(url)
    .pipe(
      map((resp: any) => {
        let unitTransport: IUnitTransport = resp;

        return {
          data: unitTransport
        }
      }),
      catchError(error => {
        return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
      })
    );
  };

  getUnitTransportByPlate(plate: string) {
    const url = `${ base_url }/unit-transport/plate/${plate}`;
    return this.http.get(url)
    .pipe(
      map((resp: any) => {
        let unitTransport: IUnitTransport = resp;

        return {
          data: unitTransport
        }
      }),
      catchError(error => {
        return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
      })
    );
  };

  deleteCompany(id: string) {
    const url = `${ base_url }/unit-transport/${id}`;
    return this.http.delete(url, this.headers);
  };

  //#endregion
}
