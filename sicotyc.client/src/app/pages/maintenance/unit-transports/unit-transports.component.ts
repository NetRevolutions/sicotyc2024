import { Component, OnDestroy, OnInit } from '@angular/core';
import { delay, Subscription } from 'rxjs';
import Swal from 'sweetalert2';

// Interfaces
import { IPagination } from 'src/app/interfaces/pagination.interface';
import { IUnitTransport } from 'src/app/interfaces/unit-transport.interface';

// Services
import { SearchesService } from 'src/app/services/searches.service';
import { UnitTransportService } from 'src/app/services/unit-transport.service';
import { ILookupCode } from 'src/app/interfaces/lookup.interface';
import { LookupService } from 'src/app/services/lookup.service';
import { EnumLookupCodeGroups } from 'src/app/enum/enums.enum';
import { ModalImageService } from 'src/app/services/modal-image.service';

@Component({
  selector: 'app-unit-transports',
  templateUrl: './unit-transports.component.html',
  styles: [
  ]
})
export class UnitTransportsComponent implements OnInit, OnDestroy {
  public loading: boolean = true;
  public pagination: IPagination = {
    pageNumber: 1,
    pageSize: 5,
    totalItems: 0
  };

  public unitTransports: IUnitTransport[] = [];
  public unitTransportsTemp: IUnitTransport[] = [];
  public brands: ILookupCode[] = [];
  public unitTransportSearch: boolean = false;
  public imgSubs: Subscription = new Subscription();
  public brandIdSelected: string = '';

  constructor(
    private searchService: SearchesService,
    private unitTransportService: UnitTransportService,
    private lookupService: LookupService,
    private modalImageService: ModalImageService
  ) { };
  
  ngOnInit(): void {
    this.loadUnitTransports();
    this.loadTypeUnitTransports();

    // Con esto indico que se termino de actualizar la imagen desde el popup
    this.imgSubs = this.modalImageService.newImage
    .pipe(
      delay(100)
    )
    .subscribe( img => {
      this.loadUnitTransports();
      this.loadTypeUnitTransports();
    });
  };

  ngOnDestroy(): void {
    this.imgSubs.unsubscribe(); // Con esto evitamos fuga de memoria  
  };

  loadUnitTransports() {
    this.loading = true;
    this.unitTransportService.getUnitTransports(this.pagination)
    .subscribe((resp: any)=> {
      this.pagination.pageSize = resp.pagination.pageSize;
      this.pagination.pageNumber = resp.pagination.pageNumber;
      this.pagination.totalItems = resp.pagination.totalCount;
      this.unitTransports = resp.data;
      this.unitTransportsTemp = resp.data;
      // console.log(this.unitTransports);
      this.loading = false;
    });
  };

  loadTypeUnitTransports() {
    this.lookupService.getLookupCodesByLCGNameALL(EnumLookupCodeGroups.TIPO_DE_UNIDAD_DE_TRANSPORTE)
    .subscribe((resp: any) => {
      this.brands = resp.data;
    });
  }

  search(searchTerm: string) {
    if (searchTerm.length === 0) {
      this.unitTransportSearch = false;
      return this.unitTransports = this.unitTransportsTemp;
    }  

    this.searchService.search('UNITTRANSPORTS', searchTerm)
    .subscribe({
      next: (resp: any) => {
        var ids = resp.result.map((e:any) => e.id);
        this.unitTransportService.getUnitTransportsByIdCollection(ids)
        .subscribe((resp2: any) => {
          this.unitTransports = resp2.data;
        });
      },
      error: (err) => { console.error(err); },
      complete: () => {}
    });
    return [];
  };

  changePage(pageNumber: number) {
    this.pagination.pageNumber = pageNumber;
    this.loadUnitTransports();
  };

  delete(entity: IUnitTransport) {
    return this.confirmDelete(entity);
  };

  confirmDelete(entity: IUnitTransport) {
    Swal.fire({
      title: 'Borrar Unidad de Transporte?',
      text: `Esta a punto de borrar la unidad de transporte con placa: ${ entity.plate }`,
      icon: 'question',
      showCancelButton: true,
      confirmButtonText: 'Si, borralo'
    }).then((result) => {
      if (result.isConfirmed) {
        this.unitTransportService.deleteCompany(entity.unitTransportId)
        .subscribe({
          next: (resp => {
            Swal.fire({
              title: 'Eliminado!',
              text: 'La Unidad de Transporte fue eliminado',
              icon: "success" 
            }).then(()=> {
              this.loadUnitTransports();
            });
          }),
          error: (err) => { Swal.fire('Error', 'Hubo un error durante el proceso de eliminacion, verifique!!!', 'error') },
          complete: () => { console.info('Unidad de Transporte fue eliminado correctamente'); }
        })
      }
    });
  };

  onChangeBrand(event: any) {
    this.brandIdSelected = event.target.value;
    // this.pagination.pageNumber = 1;
    // this.pagination.pageSize = 5;
    // this.pagination.totalItems = 0;
    console.log(this.brandIdSelected);
  };

  openModalImage(unitTransport: IUnitTransport)
  {    
    this.modalImageService.openModal('UNITTRANSPORTS', unitTransport.unitTransportId, unitTransport.img)
  };

}
