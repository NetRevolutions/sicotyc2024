import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EnumLookupCodeGroups } from 'src/app/enum/enums.enum';
import Swal from 'sweetalert2';

// Interfaces
import { ICompany } from 'src/app/interfaces/company.interface';
import { ILookupCode } from 'src/app/interfaces/lookup.interface';

// Servicios
import { CompanyService } from 'src/app/services/company.service';
import { ModalCompanyService } from 'src/app/services/modal-company.service';
import { LookupService } from 'src/app/services/lookup.service';


@Component({
  selector: 'app-modal-company',
  templateUrl: './modal-company.component.html',
  styles: [
  ]
})
export class ModalCompanyComponent implements OnInit{
  public existCompany: boolean=false;
  public registerNewCompany: boolean=false;
  public searchTypeKey: string = 'ruc';
  public searchPlaceHolder: string = 'Ingrese Ruc';
  public searchValue: string = '';
  public companyResults: ICompany[] = [];
  public companyTypesDB: ILookupCode[] = [];
  public companyForm: FormGroup;
  public companyTypesSelected: string[] = []; // Lista de valores seleccionados  

  public modalContentWidth: string = '880px'; // Default: 500px

  @Input() ruc?: string = '';
  @Output() valorSalidaModal: EventEmitter<ICompany> = new EventEmitter();

  constructor(
    public modalCompanyService: ModalCompanyService,
    public companyService: CompanyService,
    private lookupService: LookupService,
    private sanitizer: DomSanitizer,
    private fb: FormBuilder, ) { 
      this.companyForm = this.fb.group({});
    }

  ngOnInit(): void {
    this.companyForm = this.fb.group({      
      ruc: ['', Validators.required],
      companyName: [{value: '', disabled: true}],
      companyComercialName: ['', Validators.required],
      companyState: [{value: '', disabled: true}],
      companyCondition: [{value: '', disabled: true}],
      companyFiscalAddress: [{value: '', disabled: true}],
      companyEmail: ['', Validators.required],
      companyPhone: ['', Validators.required]
    });    
  }; 

  closeModal() {
    this.resetValues();
    this.modalCompanyService.closeModal();
  };

  resetValues() {
    this.existCompany = false;
    this.registerNewCompany = false;
    this.searchTypeKey = 'ruc';
    this.searchPlaceHolder = 'Ingrese Ruc';
    this.searchValue = '';
    this.companyResults = [];
    this.companyTypesDB = [];
    this.companyForm = this.fb.group({});
    this.companyTypesSelected = []; // Lista de valores seleccionados  
    this.modalContentWidth = '500px';
  }

  searchType(searchTypeKey: string) {
      this.searchTypeKey = searchTypeKey;
      switch (searchTypeKey) {
        case 'ruc':
          this.resetValues();
          this.searchTypeKey = searchTypeKey;
          this.searchPlaceHolder = 'Ingrese Ruc';              
          break;
        case 'razsoc':
          this.resetValues();
          this.searchTypeKey = searchTypeKey;
          this.searchPlaceHolder = 'Ingrese Nombre o Razon Social';            
          break;
        default:
          this.resetValues();
          this.searchPlaceHolder = 'Ingrese Ruc';
          break;
      }
  };

  search() {
    this.lookupService.getLookupCodesByLCGNameALL(EnumLookupCodeGroups.TIPO_DE_EMPRESA)
    .subscribe((resp1: any) => {
      this.companyTypesDB = resp1.data;
      this.companyResults = [];

      if (this.searchTypeKey == 'ruc') {    
        this.companyService.getCompanyByRuc(this.searchValue)
        .subscribe({
          next: (resp2: any) => {
            let result = resp2.data;
            if (result != null) {
              this.existCompany = true;
              this.modalContentWidth = '880px';
              this.companyResults.push(result);
              this.companyResults = this.processRespData(this.companyResults);
            } else {
              this.existCompany = false;
              this.modalContentWidth = '500px';
              Swal.fire({
                title: 'Atencion',
                text: `El ruc: ${this.searchValue} no existe, desea registrarlo?`,
                icon: 'question',
                showCancelButton: true,
                confirmButtonText: 'Si, registralo'
              }).then((result) => {
                if (!result.isDismissed)
                {
                  this.registerNewCompany = true;
                }             
              })
            }
          },
          error: (err) => {
            Swal.fire('Error', err.error.msg, 'error');
          },
          complete: () => console.info('Busqueda exitosa')
        });
      }
      else if (this.searchTypeKey == 'razsoc') {
        this.companyService.getCompanyByName(this.searchValue)
        .subscribe({
          next: (resp3) => {
            let result = resp3.data;
            if (result != null && result.length > 0)
            {
              this.existCompany = true;
              this.modalContentWidth = '880px';
              this.companyResults = result;
              this.companyResults = this.processRespData(this.companyResults);
            }
            else {
              this.existCompany = false;
              this.modalContentWidth = '500px';
            }
          },
          error: (err) => {
            Swal.fire('Error', err.error.msg, 'error');
          },
          complete: () => console.info('Busqueda exitosa')
        });
      }
    });    
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
  };  

  seleccionar(entity: ICompany) {
    this.valorSalidaModal.emit(entity);
    this.resetValues();
    this.closeModal();
  };

  onCompanyTypeChange(event: Event): void {
    const checkbox = event.target as HTMLInputElement;
    const value = checkbox.value;
  
    if (checkbox.checked) {
      if (!this.companyTypesSelected.includes(value)) {
        this.companyTypesSelected.push(value);
      }
    } else {
      this.companyTypesSelected = this.companyTypesSelected.filter(
        selected => selected !== value
      );
    }
  };

  save() {
    // Crear
    const data = {
      ...this.companyForm.value,
      //companyName: this.companySelected?.companyName,
      companyTypes: this.companyTypesSelected // Lista de valores seleccionados
    };

    this.companyService.createCompany(data)
    .subscribe({
      next: (resp) => {
        Swal.fire('Creado', 'Empresa creada correctamente', 'success');
        this.registerNewCompany = false;
        this.existCompany = true;
        this.companyService.getCompanyByRuc(data.ruc)
        .subscribe({
          next: (resp2) => {
            this.companyResults = [];
            let result = resp2.data;
            if (result != null) {
              this.companyResults.push(result);
              this.companyResults = this.processRespData(this.companyResults);
            }
          }, 
          error: (err) => {
            Swal.fire('Error', err.error.msg, 'error');
          },
          complete: () => console.info('Busqueda exitosa')
        });
      },
      error: (err) => {
        Swal.fire('Error', err.error.msg, 'error');
      },
      complete: () => console.info('Empresa creada satisfactoriamente')
    });
  };
}
