import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment';
import { catchError, map, throwError } from 'rxjs';

// Services
import { UserService } from './user.service';
import { ValidationErrorsCustomizeService } from './validation-errors-customize.service';

// Interfaces
import { IDriver, IDriverForCreation, IDriverForUpdate } from '../interfaces/driver.interface';
import { IPagination } from '../interfaces/pagination.interface';


const base_url = environment.base_url;

@Injectable({
  providedIn: 'root'
})
export class DriverService {

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
  createDriver(formData: IDriverForCreation) {    
    var claims = this.userService.getClaimsFromLocalStorage(); 
    var userId = claims.find(f => f.type == 'Id').value.toString();   

    const data = {
      ...formData,
      createdBy: userId 
    };

    return this.http.post(`${base_url}/driver`, data, this.headers)
    .pipe(
      catchError(error => {
        return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
      })
    );
  };

  updateDriver(formData: IDriverForUpdate) {
    var claims = this.userService.getClaimsFromLocalStorage(); 
    var userId = claims.find(f => f.type == 'Id').value.toString();  

    formData.driverLicenses.forEach(x => {
      x.updatedBy = userId
    });

    const data = {
      ...formData,
      
      updatedBy: userId
    };

    return this.http.put(`${ base_url }/driver/${formData.driverId}`, data, this.headers)
    .pipe(
      catchError(error => {
        return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
      })   
    );
  };

  getDrivers(pagination: IPagination, searchTerm: string = '') {    
    const url = `${ base_url }/driver/getDrivers?pageNumber=${pagination.pageNumber}&pageSize=${pagination.pageSize}&searchTerm=${searchTerm}`;
    return this.http.get(url, this.headers)
      .pipe(
        map((resp:any) => {
          let drivers: IDriver[] = resp.data;
          drivers.forEach(driver => {
            driver.imgUrl = this.imageUrl(driver.img);
          });

          return {
            data: drivers,
            pagination: resp.pagination
          }
        }),
        catchError(error => {
          return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
        })
      );
  };

  getDriversByIdCollection(ids: string[]) {
    const url = `${ base_url }/driver/collection(${ids.join(',')})`;
    return this.http.get(url)
    .pipe(
      map((resp: any) => {
        let drivers: IDriver[] = resp.map((d: any) => ({
          driverId: d.driverId,
          ruc: d.ruc,
          firstName: d.firstName,
          lastName: d.lastName,
          img: d.img,
          documentType: d.documentType,
          documentNumber: d.documentNumber,
          documentExpiration: d.documentExpiration,  
          driverLicenses: d.driverLicenses,        
          enableIMO: d.enableIMO,
          dateOfBirth: d.dateOfBirth,
          address: d.address,
          antecedentePolicialesExpiration: d.antecedentePolicialesExpiration,
          antecedentesPenalesExpiration: d.antecedentesPenalesExpiration,
          imgUrl: this.imageUrl(d.img)
        }));
        return {
          data: drivers
        }
      }),
      catchError(error => {
        return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
      })
    )
  };

  getAllDrivers() {
    const url = `${ base_url }/driver/getCompanies/All`;
    return this.http.get(url)
      .pipe(
        map((resp:any) => {
          let drivers: IDriver[] = resp.data;

          return {
            data: drivers
          }
        }),
        catchError(error => {
          return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
        })
      );
  };

  getDriverById(driverId: string) {
    const url = `${ base_url }/driver/${driverId}`;
    return this.http.get(url)
      .pipe(
        map((resp:any) => {
          let driver: IDriver = resp;

          return {
            data: driver
          }
        }),
        catchError(error => {
          return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
        })
      );
  };

  getDriverByDocument(documentNumber: string) {
    const url = `${base_url}/driver/docNumber/${documentNumber}`;
    return this.http.get(url)
    .pipe(
      map((resp:any) => {
        let driver: IDriver = resp;

        return {
          data: driver
        }
      }),
      catchError(error => {
        return throwError(() => new Error(this.validationErrorsCustomize.messageCatchError(error)));
      })
    );
  };

  deleteDriver(id: string) {
    const url = `${ base_url }/driver/${id}`;
    return this.http.delete(url, this.headers);
  };

  imageUrl(img: string) {
    if (!img) {
      return `${base_url}/upload/drivers/no-image`;
    } else if (img) {
      return `${base_url}/upload/drivers/${img}`;
    } else {
      return `${base_url}/upload/drivers/no-image`;
    }
  }

  //#endregion

  
}
