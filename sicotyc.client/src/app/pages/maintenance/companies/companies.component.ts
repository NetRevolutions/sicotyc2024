import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import Swal from 'sweetalert2';
import { EnumLookupCodeGroups } from 'src/app/enum/enums.enum';
import { DomSanitizer, SafeHtml } from '@angular/platform-browser';

// Interfaces
import { ICompany } from 'src/app/interfaces/company.interface';
import { IPagination } from 'src/app/interfaces/pagination.interface';
import { ILookupCode } from 'src/app/interfaces/lookup.interface';

// Services
import { SearchesService } from 'src/app/services/searches.service';
import { CompanyService } from 'src/app/services/company.service';
import { LookupService } from 'src/app/services/lookup.service';

@Component({
  selector: 'app-companies',
  templateUrl: './companies.component.html',
  styles: [
  ]
})
export class CompaniesComponent implements OnInit, OnDestroy {
  public loading: boolean = true;
  public pagination: IPagination = {
    pageNumber: 1,
    pageSize: 5,
    totalItems: 0
  };
  
  public companies: ICompany[] = [];
  public companiesTemp: ICompany[] = [];
  public companyTypesDB: ILookupCode[] = [];
  public useSearch: boolean = false;
  public companiesSubs: Subscription = new Subscription();
  
  constructor(
    private searchService: SearchesService,
    private companyService: CompanyService,
    private lookupService: LookupService,
    private sanitizer: DomSanitizer
    ) {};
  
  ngOnInit(): void {
    this.loadCompanyTypes();
    this.loadCompanies();
  }; 

  ngOnDestroy(): void {
    this.companiesSubs.unsubscribe(); // Con esto evitamos fuga de memoria  
  };

  loadCompanies() {
    this.loading = true;
    this.companyService.getCompanies(this.pagination)
    .subscribe((resp: any) => {
      this.pagination.pageSize = resp.pagination.pageSize;
      this.pagination.pageNumber = resp.pagination.pageNumber;
      this.pagination.totalItems = resp.pagination.totalCount;
      this.companies = this.processRespData(resp.data);
      this.companiesTemp = this.processRespData(resp.data);
      this.loading = false;
    });
  };
  
  search(searchTerm: string) {
    if (searchTerm.length <= 2) {
      this.useSearch = false;
      return this.companies = this.companiesTemp;
    }  

    this.searchService.search('COMPANIES', searchTerm)
    .subscribe((resp: any) => {
      if (resp.result.length > 0) {
        this.useSearch = true;
        var ids = resp.result.map((e:any) => e.id)

        this.companyService.getCompaniesByIdCollection(ids)
        .subscribe((resp: any) => {
          this.companies = this.processRespData(resp.data);
        });
      }
      else {
        this.useSearch = false;
      }
    });
    return [];
  };

  changePage(pageNumber: number) {
    this.pagination.pageNumber = pageNumber;
    this.loadCompanies();
  };

  delete(entity: ICompany) {
    return this.confirmDelete(entity);
  };

  confirmDelete(entity: ICompany) {
    Swal.fire({
      title: 'Borrar Lookup Code Group?',
      text: `Esta a punto de borrar la empresa: ${ entity.companyName }`,
      icon: 'question',
      showCancelButton: true,
      confirmButtonText: 'Si, borralo'
    }).then((result) => {
      if (result.isConfirmed) {
        this.companyService.deleteCompany(entity.companyId)
        .subscribe({
          next: (resp) => {
            Swal.fire({
              title: 'Eliminado!',
              text: 'La empresa fue eliminada',
              icon: "success"
            }).then(() => {
              this.loadCompanies();
            });
          },
          error: (err) => {
            Swal.fire('Error', 'Hubo un error durante el proceso de eliminacion, verifique!!!', 'error');
          },
          complete: () => {
            console.info('La empresa fue eliminada correctamente');
          }
        });
      }
    })
  };

  loadCompanyTypes() {
    this.lookupService.getLookupCodesByLCGNameALL(EnumLookupCodeGroups.TIPO_DE_EMPRESA)
    .subscribe((resp: any) => {
      this.companyTypesDB = resp.data;
    })
  };

  processRespData(companyData: ICompany[]) {
    if (companyData.length > 0) {
      companyData.forEach(element => {
        if (element.companyTypes != null && element.companyTypes.length > 0) {
          let stringCompanyTypes = '<ul>';
          element.companyTypes.forEach(ct => {
            stringCompanyTypes += '<li>' + this.companyTypesDB.find(f => f.lookupCodeValue == ct)?.lookupCodeName + '</li>'
          });
          stringCompanyTypes += '</ul>';
          // Usa DomSanitizer para marcar el HTML como seguro
        element.companyTypesHtml = this.sanitizer.bypassSecurityTrustHtml(stringCompanyTypes);
        }        
      });
    }
    return companyData;
    
  }
}
