import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { environment } from 'src/environments/environment';
import { delay, map } from 'rxjs/operators';
import Swal from 'sweetalert2';

const base_url = environment.base_url;

// Interfaces
import { IDriver, IDriverLicense, IDriverLicenseForCreation, IDriverLicenseforUpdate } from 'src/app/interfaces/driver.interface';
import { ILookupCode } from 'src/app/interfaces/lookup.interface';

// Enum
import { EnumLookupCodeGroups } from 'src/app/enum/enums.enum';

// Services
import { DriverService } from 'src/app/services/driver.service';
import { LookupService } from 'src/app/services/lookup.service';
import { UserService } from 'src/app/services/user.service';
import { FileUploadService } from 'src/app/services/file-upload.service';

@Component({
  selector: 'app-driver',
  templateUrl: './driver.component.html',
  styles: [
    `.swal2-popup {
      width: 600px; /* Ajusta el ancho según tus necesidades */
      padding: 1rem; /* Ajusta el padding según tus necesidades */
    }`
  ]
})
export class DriverComponent implements OnInit {
  public driverForm: FormGroup;
  public driverSelected?: IDriver
  public title: string = 'Conductor';
  public subTitle: string = 'Actualizar Conductor';
  public typeOfDocuments: ILookupCode[] = [];
  public typeOfLicenses: ILookupCode[] = [];
  public driverLicences: IDriverLicense[] = [];  
  public imgUpload?: File;
  public imgTemp: any;
  public noImageDriver = `${base_url}/upload/drivers/no-image`;

  constructor(
    private fb: FormBuilder,
    private driverService: DriverService,
    private lookupService: LookupService,
    private userService: UserService,
    private fileUploadService: FileUploadService,
    private router: Router,
    private activatedRouter: ActivatedRoute
  ) {
    this.driverForm = this.fb.group({});    
  }

  ngOnInit(): void {
    this.activatedRouter.params
    .subscribe(params => {      
      this.loadTypeOfDocuments();
      this.loadTypeOfLicenses();
      this.loadDriver(params['id']);

    });

    this.driverForm = this.fb.group({
      ruc: ['', [Validators.required, Validators.minLength(11), Validators.maxLength(11)]],
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      documentType: ['', Validators.required],
      documentNumber: ['', Validators.required],
      documentExpiration: ['', Validators.required],
      //driverLicenses: ['', Validators.required],
      enableIMO: [{value: false, disabled: true}],
      dateOfBirth: [''],
      address: [''],
      antecedentesPolicialesExpiration: [''],
      antecedentesPenalesExpiration: ['']
    });
  };  

  loadTypeOfDocuments() {
    this.lookupService.getLookupCodesByLCGNameALL(EnumLookupCodeGroups.TIPO_DOCUMENTO)
    .subscribe(resp => {
      this.typeOfDocuments = resp.data;
    });    
  };

  loadTypeOfLicenses() {
    this.lookupService.getLookupCodesByLCGNameALL(EnumLookupCodeGroups.TIPO_LICENCIA_CONDUCIR)
    .subscribe(resp => {
      this.typeOfLicenses = resp.data;
    });
  }

  loadDriver(driverId: string) {
    let claims = this.userService.getClaimsFromLocalStorage(); 
    let userId = claims.find(f => f.type == 'Id').value.toString();
    let role = claims.find(f =>  f.type == 'Role').value.toString();    
    
    this.userService.getUserById(userId)
    .subscribe((userLogged: any) => {
      this.driverForm.get('ruc')?.setValue(userLogged.data.ruc);

      if (role !== 'Administrator') {
        const rucControl = this.driverForm.get('ruc');
        if (rucControl) {
          rucControl.disable();
        } else {
          console.error('RUC control not found');
        }
      }
    });    

    if (driverId == 'new') {      
      this.subTitle = 'Crear nuevo conductor';    
      return;
    }

    this.driverService.getDriverById(driverId)
    .subscribe((resp: any) => {
      const { ruc, firstName, lastName, documentType, documentNumber, documentExpiration, driverLicenses, enableIMO, dateOfBirth, address, antecedentesPolicialesExpiration, antecedentesPenalesExpiration } = resp.data;
      this.driverSelected = resp.data; 
      this.driverSelected!.imgUrl = this.driverSelected?.img == undefined ? this.noImageDriver : `${base_url}/upload/drivers/${this.driverSelected.img}`;     
         
      this.driverLicences = this.driverSelected?.driverLicenses ? this.driverSelected?.driverLicenses : [];      
      
      this.driverForm.setValue({
        ruc: ruc, 
        firstName, 
        lastName, 
        documentType, 
        documentNumber, 
        documentExpiration: this.convertDateToString(new Date(documentExpiration)), 
        enableIMO, 
        dateOfBirth: this.convertDateToString(new Date(dateOfBirth)), 
        address, 
        antecedentesPolicialesExpiration: this.convertDateToString(new Date(antecedentesPolicialesExpiration)), 
        antecedentesPenalesExpiration: this.convertDateToString(new Date(antecedentesPenalesExpiration))
      });
      
      if (this.driverLicences.length > 0 && this.driverLicences.some(d => d.licenseType == 'A4'))
      {
        this.driverForm.get('enableIMO')?.setValue(true);
      }

      return false;
    });
  };

  saveDriver() {    
    let claims = this.userService.getClaimsFromLocalStorage(); 
    let userId = claims.find(f => f.type == 'Id').value.toString();
    let role = claims.find(f =>  f.type == 'Role').value.toString();

    if (this.driverSelected) {
      // Update           
      let driverLicencesForUpdate: IDriverLicenseforUpdate[] = [];
      // Set Driver Licenses
      if (this.driverLicences.length > 0) {       
        this.driverLicences.forEach(d => {
          driverLicencesForUpdate.push({
            driverId: this.driverSelected!.driverId,
            driverLicenseId: '',
            licenseType: d.licenseType,
            licenseNumber: d.licenseNumber,
            licenseExpiration: d.licenseExpiration,
            updatedBy: userId
          });
        });
      };

      this.driverForm.get('antecedentesPolicialesExpiration')?.setValue(!this.driverForm.get('antecedentesPolicialesExpiration')?.value ? '1970-01-01' : this.convertDateToString(new Date(this.driverForm.get('antecedentesPolicialesExpiration')?.value)));
      this.driverForm.get('antecedentesPenalesExpiration')?.setValue(!this.driverForm.get('antecedentesPenalesExpiration')?.value ? '1970-01-01' : this.convertDateToString(new Date(this.driverForm.get('antecedentesPenalesExpiration')?.value)));

      const data = {
        ...this.driverForm.value,
        driverId: this.driverSelected.driverId,  
        enableIMO: this.driverForm.get('enableIMO')?.value, 
        driverLicenses: driverLicencesForUpdate     
      };

      this.driverService.updateDriver(data)
      .subscribe((resp: any) => {
        Swal.fire('Actualizado', 'Chofer actualizado correctamente', 'success');
      });
    }
    else {
      // Create
      let driverLicencesForCreation: IDriverLicenseForCreation[] = [];
      // Set Driver Licenses
      if (this.driverLicences.length > 0) {
        this.driverLicences.forEach(d => {
          driverLicencesForCreation.push({
            driverId: '00000000-0000-0000-0000-000000000000',
            driverLicenseId: '00000000-0000-0000-0000-000000000000',
            licenseType: d.licenseType,
            licenseNumber: d.licenseNumber,
            licenseExpiration: d.licenseExpiration,
            createdBy: userId
          });
        });
      };

      this.driverForm.get('antecedentesPolicialesExpiration')?.setValue(!this.driverForm.get('antecedentesPolicialesExpiration')?.value ? '1970-01-01' : this.convertDateToString(new Date(this.driverForm.get('antecedentesPolicialesExpiration')?.value)));
      this.driverForm.get('antecedentesPenalesExpiration')?.setValue(!this.driverForm.get('antecedentesPenalesExpiration')?.value ? '1970-01-01' : this.convertDateToString(new Date(this.driverForm.get('antecedentesPenalesExpiration')?.value)));

      const data = {
        ...this.driverForm.value,
        enableIMO: this.driverForm.get('enableIMO')?.value,
        driverLicenses: driverLicencesForCreation
      };      

      // 1.- Validamos si el conductor ya se encuentra registrado
      this.driverService.getDriverByDocument(this.driverForm.get('documentNumber')?.value)
      .subscribe((driver: any) => {
        // Validar si existe o no, en caso existe y el ruc es diferente 
        // al logueado debe de actualizar los datos un administrador
        if (driver.data) {
          Swal.fire('Atencion', 'El conductor ya se encuentra registrado, debe de buscarlo y actualizar sus datos', 'info');          
        }
        else {      
          this.userService.getUserById(userId)
          .subscribe((userLogged: any) => {
            if (userLogged.data.ruc != this.driverForm.get('ruc')?.value && role == 'Administrator') {
              // Conductor no existe, lo registro sin problemas.        
              this.driverService.createDriver(data)
              .subscribe((resp: any) => {
                Swal.fire('Creado', 'Conductor creado correctamente', 'success'); 

                this.router.navigateByUrl(`/mantenimientos/drivers/${resp.driverId}`);
                
              });
            }
            else if (userLogged.data.ruc != this.driverForm.get('ruc')?.value && role != 'Administrator') {
              Swal.fire('Atencion', 'Esta intentando registrar un conductor con un ruc asociado a otra empresa, debe de enviar el SCTR del conductor a actualizacion_datos@sicotyc.com para realizar su registro', 'info');
            }
            else {
              // Conductor no existe, lo registro sin problemas.  
              this.driverService.createDriver(data)
              .subscribe((resp: any) => {
                Swal.fire('Creado', 'Conductor creado correctamente', 'success');  
                
                this.router.navigateByUrl(`/mantenimientos/drivers/${resp.driverId}`);
                
              });
            }
          });          
        }        
      });
    }
  };

  showLicensePopup(mode: string = 'new', typeLicenseValue?: string, numberLicenseValue?: string, expirationLicenseValue?: string): void {
    Swal.fire({
      title: 'Agregar Licencia',
      html: `   
        <div style="width: fit-content;">   
          <div class="form-group row" style="margin-bottom: 1rem;">
            <label for="swal-licenseType" class="col-sm-4 control-label" style="text-align: right;">Tipo de Licencia:</label>
            <div class="col-sm-8">
              <div class="input-group">
                <select id="swal-licenseType" class="form-control">
                  ${this.getOptionsTypeOflicenses(mode, typeLicenseValue)}
                </select>
              </div>
            </div>          
          </div>
          
          <div class="form-group row" style="margin-bottom: 1rem;">
            <label for="swal-licenseNumber" class="col-sm-4 control-label" style="text-align: right;">Nro de Licencia:</label>
            <div class="col-sm-8">
              <div class="input-group">
                <input type="text" id="swal-licenseNumber" class="form-control" placeholder="Ingrese el nro aqui" value="${numberLicenseValue == undefined ? '': numberLicenseValue}">
              </div>
            </div>
          </div>

          <div class="form-group row" style="margin-bottom: 1rem;">
            <label for="swal-licenseExpirationDate" class="col-sm-4 control-label" style="text-align: right;">Fecha de Expiracion:</label>
            <div class="col-sm-6">
              <div class="input-group">
                <input type="date" id="swal-licenseExpirationDate" class="form-control" placeholder="Ingrese la fecha aqui" value="${expirationLicenseValue == undefined ? '' : expirationLicenseValue}">          
              </div>
            </div>
          </div>
        </div>    
      `,
      focusConfirm: false,
      showCancelButton: true,      
      preConfirm: (): { licenseType: string, licenseNumber: string, licenseExpiration: string } | false => {
        const licenseTypeInput = (document.getElementById('swal-licenseType') as HTMLSelectElement).value;
        const licenseNumberInput = (document.getElementById('swal-licenseNumber') as HTMLInputElement).value;
        const licenseExpirationInput = (document.getElementById('swal-licenseExpirationDate') as HTMLInputElement).value;
        if (!licenseTypeInput || !licenseNumberInput || !licenseExpirationInput) {
          Swal.showValidationMessage('Todos los campos son obligatorios');
          return false;
        }
        return { licenseType: licenseTypeInput, licenseNumber: licenseNumberInput, licenseExpiration: licenseExpirationInput } ;
      }
    }).then((result) => {      
      if (result.isConfirmed) { 
        let licenseNumber = result.value?.licenseNumber;
        let licenseType = result.value?.licenseType;
        let licenseExpiration = result.value?.licenseExpiration;        
        
        //1. Validar si Licencia ya existe dentro de la lista actual
        if (mode != 'new') {
          this.driverLicences = this.driverLicences.filter(l => !(l.licenseType === licenseType && l.licenseNumber === licenseNumber));
        };

        if (this.driverLicences && this.driverLicences.length> 0) {
          if (!this.driverLicences.some(l => l.licenseType == licenseType && l.licenseNumber == licenseNumber)) {

            let newDate = new Date(licenseExpiration);           

            this.driverLicences.push({
              driverId: '',
              driverLicenseId: '',
              licenseType: licenseType,
              licenseNumber: licenseNumber,
              licenseExpiration: this.convertDateToString(new Date(newDate.setDate(newDate.getDate() + 1)))   
            });              
            if (this.driverLicences.length > 0 && this.driverLicences.some(d => d.licenseType == 'A4')) {
              this.driverForm.get('enableIMO')?.setValue(true);
            }
            else {
              this.driverForm.get('enableIMO')?.setValue(false);
            }     
          }
          else {
            Swal.fire('Atencion', 'Los datos de la licencia que pretende ingresar ya existen, pruebe actualizarlos o eliminarlos', 'error');
          };
        }
        else {         
          let newDate = new Date(licenseExpiration);  

          this.driverLicences.push({
            driverId: '',
            driverLicenseId: '',
            licenseType: licenseType,
            licenseNumber: licenseNumber,
            licenseExpiration: this.convertDateToString(new Date(newDate.setDate(newDate.getDate() + 1)))
          });

          if (this.driverLicences.length > 0 && this.driverLicences.some(d => d.licenseType == 'A4')) {
            this.driverForm.get('enableIMO')?.setValue(true);
          }
          else {
            this.driverForm.get('enableIMO')?.setValue(false);
          }  
        };
        
        //this.driverForm.get('driverLicenses')?.setValue(this.driverLicences);
      }
    });
  };

  addLicense() {
    this.showLicensePopup('new', undefined, undefined, undefined);
  };

  editLicense(item: IDriverLicense) {
    this.showLicensePopup('edit', item.licenseType, item.licenseNumber, this.convertDateToString(new Date(item.licenseExpiration)));
  };

  deleteLicense(item: IDriverLicense) {
    this.driverLicences = this.driverLicences.filter(l => !(l.licenseType === item.licenseType && l.licenseNumber === item.licenseNumber));
    
    if (this.driverLicences.length > 0 && this.driverLicences.some(d => d.licenseType == 'A4')) {
      this.driverForm.get('enableIMO')?.setValue(true);
    }
    else {
      this.driverForm.get('enableIMO')?.setValue(false);
    }  
  };

  getOptionsTypeOflicenses(mode: string, selectedOption?: string): string {
    if (mode == 'new' && selectedOption == undefined) {
      return '<option value="" disabled selected>Seleccione</option>' +
      this.typeOfLicenses.map(option => `<option value="${option.lookupCodeValue.replace(/ /g, '')}">${option.lookupCodeName}</option>`).join('');
    }
    else if (mode != 'new' && selectedOption != undefined) {
      return '<option value="" disabled selected>Seleccione</option>' + 
      this.typeOfLicenses.map(option => `<option value="${option.lookupCodeValue.replace(/ /g, '')}" ${option.lookupCodeValue === selectedOption ? 'selected' : ''}>${option.lookupCodeName}</option>`).join('');;
    }
    else {
      return '<option value="" disabled selected>Seleccione</option>' +
      this.typeOfLicenses.map(option => `<option value="${option.lookupCodeValue.replace(/ /g, '')}">${option.lookupCodeName}</option>`).join('');
    }
  };

  getLicenseNameByLicenseType(licenseType: string) {
    let licenseName = this.typeOfLicenses.filter(l => l.lookupCodeValue == licenseType);
    return licenseName ? licenseName[0].lookupCodeName : '';
  };

  changeImage(file: File) {
    this.imgUpload = file;

    if (!file) { 
      this.imgTemp = null; 
      return;
    }

    const reader = new FileReader();
    reader.readAsDataURL( file );

    reader.onloadend = () => {
      this.imgTemp = reader.result?.toString();         
    }
  };

  uploadImage() {
    this.fileUploadService
      .updatePhoto(this.imgUpload!, 'DRIVERS', this.driverSelected?.driverId!)
      .then( img => {             
        this.driverSelected!.img = img;
        this.driverSelected!.imgUrl = `${base_url}/upload/drivers/${this.driverSelected!.img}`;
        Swal.fire("Exito", 'Imagen de conductor actualizada', 'success');    
      })
      .catch( err => {
        console.log(err);
        Swal.fire('Error', 'No se pudo subir la imagen', 'error');
      });
  };

  formIsValid() {
    return this.driverForm.invalid;
  }
  
  convertDateToString(fecha: Date): string {
    const anio = fecha.getFullYear();
    const mes = ('0' + (fecha.getMonth() + 1)).slice(-2);
    const dia = ('0' + fecha.getDate()).slice(-2);

    return `${anio}-${mes}-${dia}`;
  };

}
