import { EventEmitter, Injectable } from '@angular/core';

// Interface
import { ICompany } from '../interfaces/company.interface';

@Injectable({
  providedIn: 'root'
})
export class ModalCompanyService {
  private _hideModal: boolean = true;
  public company?: ICompany;
  public ruc?: string;

  public companyResult: EventEmitter<ICompany> = new EventEmitter<ICompany>();

  get hideModal() {
    return this._hideModal;  
  };

  openModal(){
    this._hideModal = false;
  };

  closeModal() {
    this._hideModal = true;
  };

  constructor() { }
}
