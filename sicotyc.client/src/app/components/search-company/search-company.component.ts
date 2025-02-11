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
  public ruc?: string = ''  
  @Input() btnClass: string = 'btn-primary';
  @Output() valorSalidaSearchCompany: EventEmitter<ICompany> = new EventEmitter();

  constructor(
    public modalCompanyService: ModalCompanyService
  ) {}
  
  ngOnInit(): void {
    this.btnClass = `btn ${ this.btnClass }`;
  };  

  buscarEmpresa() {  
    this.ruc = ''; 
    this.modalCompanyService.openModal();
  };

  onModalCompanyResult(result: any) {
    if (result) this.ruc = result.ruc;  
    this.valorSalidaSearchCompany.emit(result);
  };
  
}
