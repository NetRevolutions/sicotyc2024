import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

// Interface
import { ICompany } from 'src/app/interfaces/company.interface';

// Components
import { ModalCompanyService } from 'src/app/services/modal-company.service';

@Component({
  selector: 'app-search-company',
  templateUrl: './search-company.component.html',
  styles: [
  ]
})
export class SearchCompanyComponent implements OnInit {
  @Input() ruc?: string = ''  
  @Input() btnClass: string = 'btn-primary';
  @Output() valorSalida: EventEmitter<ICompany> = new EventEmitter();

  constructor(
    public modalCompanyService: ModalCompanyService
  ) {}
  
  ngOnInit(): void {
    this.btnClass = `btn ${ this.btnClass }`;
  };  

  buscarEmpresa() {   
    this.modalCompanyService.openModal();
  };

  onModalCompanyResult(result: any) {
    // modalCompanyService.companyResult
    console.log(this.modalCompanyService.companyResult);
    console.log(result);
  };
  
}
