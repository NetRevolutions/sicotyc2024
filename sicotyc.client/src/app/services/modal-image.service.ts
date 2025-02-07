import { EventEmitter, Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

const base_url = environment.base_url;

@Injectable({
  providedIn: 'root'
})
export class ModalImageService {
  private _hideModal: boolean = true;
  public folderFile?: 'USERS'|'DRIVERS'|'UNITTRANSPORTS';
  public id?: string;
  public img?: string;

  public newImage: EventEmitter<string> = new EventEmitter<string>();

  get hideModal() {
    return this._hideModal;
  }

  openModal(
    folderFile: 'USERS'|'DRIVERS'|'UNITTRANSPORTS',
    id: string = '',
    img: string = 'no-image'
  ) {
    this._hideModal = false;
    this.folderFile = folderFile;
    this.id = id;
    this.img = `${ base_url }/upload/${ folderFile }/${ img }`    
  }

  closeModal() {
    this._hideModal = true;
  }

  constructor() { }
}
