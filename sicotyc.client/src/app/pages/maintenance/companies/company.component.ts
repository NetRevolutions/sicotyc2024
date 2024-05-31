import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

// Interfaces
import { ICompany } from 'src/app/interfaces/company.interface';
import { CompanyService } from 'src/app/services/company.service';
import Swal from 'sweetalert2';

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

  constructor(
    private fb: FormBuilder,
    private companyService: CompanyService,
    private router: Router,
    private activatedRouter: ActivatedRoute
  ) {
    this.companyForm = this.fb.group({});
  }
  
  ngOnInit(): void {
    this.activatedRouter.params
    .subscribe(params => {
      this.loadCompany(params['id']);
      
    });

    this.companyForm = this.fb.group({
      // ruc: [this.companySelected?.ruc, Validators.required],
      // companyName: [{value: this.companySelected?.companyName, disabled: true}],
      // companyComercialName: [this.companySelected?.companyComercialName, Validators.required],
      // companyState: [{value: this.companySelected?.companyState, disabled: true}],
      // companyCondition: [{value: this.companySelected?.companyCondition, disabled: true}],
      // companyFiscalAddress: [{value: this.companySelected?.companyFiscalAddress, disabled: true}],
      // companyEmail: [this.companySelected?.companyEmail, Validators.required],
      // companyPhone: [this.companySelected?.companyPhone, Validators.required]
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
      const { ruc, companyName, companyComercialName, companyState, companyCondition, companyFiscalAddress, companyEmail, companyPhone} = resp.data;
      this.companySelected = resp.data;
      this.companyForm.setValue({ruc, companyName, companyComercialName, companyState, companyCondition, companyFiscalAddress, companyEmail, companyPhone});
      return false;
    })
  };

  save() {
    if (this.companySelected){
      // Actualizar
      const data = {
        ...this.companyForm.value,
        companyId: this.companySelected?.companyId
      };

      this.companyService.updateCompany(data)
      .subscribe((resp:any) => {
        Swal.fire('Actualizado', 'Empresa actualizado correctamente', 'success');
      });
    }
    else {
      // Crear
      const data = {
        ...this.companyForm.value
      };

      this.companyService.createCompany(data)
      .subscribe((resp: any) => {
        Swal.fire('Creado', 'Empresa creada correctamente', 'success');
        this.router.navigateByUrl(`/mantenimientos/companies/${resp.companyId}`);
      });
    }
  }
}
