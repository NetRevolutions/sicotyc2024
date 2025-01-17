import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import Swal from 'sweetalert2';
import { EnumLookupCodeGroups } from 'src/app/enum/enums.enum';

// Interfaces
import { ICompany } from 'src/app/interfaces/company.interface';
import { ILookupCode } from 'src/app/interfaces/lookup.interface';

// Services
import { CompanyService } from 'src/app/services/company.service';
import { LookupService } from 'src/app/services/lookup.service';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styles: [
  ]
})
export class CompanyComponent implements OnInit{
  public companyForm: FormGroup;
  public companySelected?: ICompany;
  public title: string = 'Empresa';
  public subtitle: string = 'Actualizar información';
  public companyTypesDB: ILookupCode[] = [];
  public companyTypesSelected: string[] = []; // Lista de valores seleccionados

  constructor(
    private fb: FormBuilder,
    private companyService: CompanyService,
    private lookupService: LookupService,
    private router: Router,
    private activatedRouter: ActivatedRoute
  ) {
    this.companyForm = this.fb.group({});
  }
  
  ngOnInit(): void {
    this.loadCompanyTypes();
    this.activatedRouter.params
    .subscribe(params => {      
      this.loadCompany(params['id']);      
    });

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

  loadCompany(companyId: string) {
    if (companyId === 'new') {
      this.subtitle = 'Crear nueva empresa';
      return;
    }

    this.companyService.getCompanyById(companyId)
    .subscribe((resp: any) => {
      const { 
        ruc, 
        companyName, 
        companyComercialName, 
        companyState, 
        companyCondition, 
        companyFiscalAddress, 
        companyEmail, 
        companyPhone, 
        companyTypes
      } = resp.data;
      
      this.companySelected = resp.data;   
      
      // Actualiza la lista de valores seleccionados
      this.companyTypesSelected = companyTypes;
      
      this.companyForm.patchValue({
        ruc, 
        companyName, 
        companyComercialName, 
        companyState, 
        companyCondition, 
        companyFiscalAddress, 
        companyEmail, 
        companyPhone
      });
      //return false;
    });
  };

  loadCompanyTypes() {
    this.lookupService.getLookupCodesByLCGNameALL(EnumLookupCodeGroups.TIPO_DE_EMPRESA)
    .subscribe((resp: any) => {
      this.companyTypesDB = resp.data;
    })
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
  }
  

  save() {
    if (this.companySelected){
      // Actualizar
      const data = {
        ...this.companyForm.value,
        companyId: this.companySelected?.companyId,
        companyName: this.companySelected?.companyName,
        companyTypes: this.companyTypesSelected // Lista de valores seleccionados
      };

      this.companyService.updateCompany(data)
      .subscribe((resp:any) => {
        Swal.fire('Actualizado', 'Empresa actualizado correctamente', 'success');
      });
    }
    else {
      // Crear
      const data = {
        ...this.companyForm.value,
        //companyName: this.companySelected?.companyName,
        companyTypes: this.companyTypesSelected // Lista de valores seleccionados
      };

      this.companyService.createCompany(data)
      .subscribe((resp: any) => {
        Swal.fire('Creado', 'Empresa creada correctamente', 'success');
        this.router.navigateByUrl(`/mantenimientos/companies/${resp.companyId}`);
      });
    }
  };
}
