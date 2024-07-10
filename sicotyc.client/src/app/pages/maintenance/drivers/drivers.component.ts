import { Component, OnDestroy, OnInit } from '@angular/core';
import { delay, Subscription } from 'rxjs';

// Interfaces
import { IDriver, IDriverLicense } from 'src/app/interfaces/driver.interface';
import { IPagination } from 'src/app/interfaces/pagination.interface';
import { ITuple } from 'src/app/interfaces/tuple.interface';
import { User } from 'src/app/models/user.model';

// Services
import { DriverService } from 'src/app/services/driver.service';
import { ModalImageService } from 'src/app/services/modal-image.service';
import { SearchesService } from 'src/app/services/searches.service';
import { UserService } from 'src/app/services/user.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-drivers',
  templateUrl: './drivers.component.html',
  styles: [
  ]
})
export class DriversComponent implements OnInit, OnDestroy {
  private userLogged!: User;
  private roleLogged: string = '';
  public drivers: IDriver[] = [];
  public driversTemp: IDriver[] = [];
  public pagination: IPagination = {
    pageNumber: 1,
    pageSize: 5,
    totalItems: 0
  };
  public loading: boolean = true;
  public useSearch: boolean = false;
  public imgSubs: Subscription = new Subscription();
  public roles: ITuple[] = [];

  constructor(
    public userService: UserService,
    public driverService: DriverService,
    private searchesService: SearchesService,
    private modalImageService: ModalImageService
  ) {};

  ngOnInit(): void {
    this.getUserLogged();
    this.loadRoles();
    this.loadDrivers();

    // Con esto indico que se termino de actualizar la imagen desde el popup
    this.imgSubs = this.modalImageService.newImage
    .pipe(
      delay(100) // con esto nos aseguramos que primero se actualice la foto  luego se llama al metodo de cargar usuarios.
    )
    .subscribe( img => {
      this.getUserLogged();
      this.loadRoles();
      this.loadDrivers();
    }); 
  };

  ngOnDestroy(): void {
    this.imgSubs.unsubscribe(); // Con esto evitamos fuga de memoria
  };

  getUserLogged(): void {
    let claims = this.userService.getClaimsFromLocalStorage(); 
    let userId = claims.find(f => f.type == 'Id').value.toString();
    let role = claims.find(f =>  f.type == 'Role').value.toString();
    this.userService.getUserById(userId)
    .subscribe((userLogged: any) => {      
      this.userLogged = userLogged.data;
      this.roleLogged = role;
    });
  };

  loadDrivers() {
    this.loading = true;
    this.driverService.getDrivers(this.pagination)
    .subscribe((resp: any) => { 
      this.pagination.pageSize = resp.pagination.pageSize;
      this.pagination.pageNumber = resp.pagination.pageNumber;
      this.pagination.totalItems = resp.pagination.totalCount;
      this.drivers = resp.data;
      this.driversTemp = resp.data;      
      this.loading = false;
    });
  };

  loadRoles() {
    this.userService.getRolesForManintenance()
    .subscribe((resp: any) => {
      this.roles = resp.roles;
    });
  };

  changePage(pageNumber: number) {
    this.pagination.pageNumber = pageNumber;
    this.loadDrivers();
  };

  search(searchTerm: string) {
    if (searchTerm.length == 0 ) {
      this.useSearch = false;
      return this.drivers = this.driversTemp;
    }

    // TODO: Concatenar el searchTerm con el RUC
    searchTerm = (this.roleLogged == 'Administrator' ) + '|' + this.userLogged.ruc + '|' +  searchTerm;

    this.searchesService.search('DRIVERS', searchTerm)
    .subscribe((resp: any) => {
      if (resp.result.length > 0) {
        this.useSearch = true;
        var ids = resp.result.map((e:any) => e.id);

        this.driverService.getDriversByIdCollection(ids)
        .subscribe((resp: any) => {
          this.drivers = resp.data;
        });        
      }
      else {
        this.useSearch = false;
      }
    });
    return [];
  };

  delete(entity: IDriver) {
    return this.confirmDelete(entity);
  };

  confirmDelete(entity: IDriver) {
    Swal.fire({
      title: 'Eliminar conductor?',
      text: `Esta a punto de eliminar al conductor: ${entity.firstName} ${entity.lastName}, esta seguro?`,
      icon: 'question',
      showCancelButton: true,
      confirmButtonText: 'Si, borralo'
    }).then((result) => {
      this.driverService.deleteDriver(entity.driverId)
      .subscribe({
        next: (resp) => {
          Swal.fire({
            title: 'Eliminado!',
            text: 'El conductor fue eliminado',
            icon: 'success'
          }).then(() => {
            this.loadDrivers();
          });
        },
        error: (err) => {
          Swal.fire('Error', 'Hubo un error durante el proceso de eliminacion, verifique!!!', 'error');
        },
        complete: () => {
          console.info('El conductor fue eliminado correctamente');
        }
      })
    })
  };

  openModalImage(driver: IDriver)
  {    
    this.modalImageService.openModal('DRIVERS', driver.driverId, driver.img)
  };

  formatDriverLicensesHTML(driverLicences: IDriverLicense[]): string {
    let htmlResult: string = '';

    if (driverLicences.length > 0) {
      htmlResult = driverLicences.map(l => l.licenseType + ' - ' + l.licenseNumber).join('<br/>');
    }
    
    return htmlResult;
  };
}
