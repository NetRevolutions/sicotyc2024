import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { environment } from 'src/environments/environment';
import { ActivatedRoute, Router } from '@angular/router';
import Swal from 'sweetalert2';

const base_url = environment.base_url;

// Interfaces
import { IUnitTransportDetail, IUnitTransport, IUnitTransportForRegistration } from 'src/app/interfaces/unit-transport.interface';
import { ILookupCode } from 'src/app/interfaces/lookup.interface';

// Services
import { UnitTransportService } from 'src/app/services/unit-transport.service';
import { LookupService } from 'src/app/services/lookup.service';
import { UserService } from 'src/app/services/user.service';
import { FileUploadService } from 'src/app/services/file-upload.service';
import { EnumLookupCodeGroups } from 'src/app/enum/enums.enum';


@Component({
  selector: 'app-unit-transport',
  templateUrl: './unit-transport.component.html',
  styles: [
    `.swal2-popup {
      width: 600px; /* Ajusta el ancho según tus necesidades */
      padding: 1rem; /* Ajusta el padding según tus necesidades */
    }`
  ]
})
export class UnitTransportComponent implements OnInit{
  public unitTransportForm: FormGroup;
  public unitTransportSelected?: IUnitTransport;
  public title: string = 'Unidad de Transporte';
  public subTitle: string = 'Actualizar Unidad de Transporte';
  public typeOfTransports: ILookupCode[] = [];
  public categories: ILookupCode[] = [];
  public models: ILookupCode[] = [];
  public typeOfFuels: ILookupCode[] = [];
  public imgUpload?: File;
  public imgTemp: any;
  public noImageUnitTransport = `${base_url}/upload/unittransports/no-image`;

  constructor(
    private fb: FormBuilder,
    private unitTransportService: UnitTransportService,
    private lookupService: LookupService,
    private userService: UserService,
    private fileUploadService: FileUploadService,
    private router: Router,
    private activatedRouter: ActivatedRoute
  ) {
    this.unitTransportForm = this.fb.group({});
  };


  ngOnInit(): void {

    this.activatedRouter.params
    .subscribe(params => {
      this.loadTypeOfTransports();
      this.loadCategories();
      this.loadFuelTypes();      
      this.loadUnitTransport(params['id']);
    });

    this.unitTransportForm = this.fb.group({
      plate: ['', [Validators.required]],
      ruc: ['', [Validators.required, Validators.minLength(11), Validators.maxLength(11)]],
      typeOfTransport: ['', [Validators.required]],
      brand: ['', [Validators.required]],
      fabricationYear: ['', [Validators.required]],
      modelYear: ['', [Validators.required]],
      soatExpiredDate: ['', [Validators.required]],
      technicalReviewExpiredDate: ['', [Validators.required]],
      vehicleQualificationExpirationDate: ['', [Validators.required]],
      vehicleQualificationNumber: ['', [Validators.required]],
      vehicleConfiguration: ['', [Validators.required]],
      additionalNotes: [''],
      fuel: [''],
      // Details
      category: [''],
      model: [''],
      color: [''],
      serialNumber: [''],
      engineNumber: [''],
      bodyWork: [''],
      large: [''],
      width: [''],
      height: [''],
      axles: ['']
    });
  };

  loadTypeOfTransports() {
    this.lookupService.getLookupCodesByLCGNameALL(EnumLookupCodeGroups.TIPO_DE_UNIDAD_DE_TRANSPORTE)
    .subscribe(resp => {
      this.typeOfTransports = resp.data;
    });  
  };

  loadCategories() {
    this.lookupService.getLookupCodesByLCGNameALL(EnumLookupCodeGroups.CATEGORIA_VEHICULOS)
    .subscribe(resp => {
      this.categories = resp.data;
    }); 
  };  

  loadFuelTypes() {
    this.lookupService.getLookupCodesByLCGNameALL(EnumLookupCodeGroups.TIPO_DE_COMBUSTIBLE)
    .subscribe(resp => {
      this.typeOfFuels = resp.data;
    });
  };

  loadUnitTransport(unitTransportId: string) {
    let claims = this.userService.getClaimsFromLocalStorage(); 
    let userId = claims.find(f => f.type == 'Id').value.toString();
    let role = claims.find(f =>  f.type == 'Role').value.toString();    

    this.userService.getUserById(userId)
    .subscribe((userLogged: any) => {
      this.unitTransportForm.get('ruc')?.setValue(userLogged.data.ruc);

      if(role != 'Administrator') {
        const rucControl = this.unitTransportForm.get('ruc');
        if (rucControl) {
          rucControl.disable();
        } else {
          console.error('RUC control not found');
        }
      }
    });
    
    if (unitTransportId == 'new') {      
      this.subTitle = 'Crear nueva Unidad de Transporte';    
      return;
    }
    
    this.unitTransportService.getUnitTransportById(unitTransportId)
    .subscribe((resp: any) => {
      const {ruc, plate, brand, fabricationYear, modelYear, soatExpiredDate, technicalReviewExpiredDate, fuel, additionalNotes, vehicleQualificationNumber, vehicleQualificationExpirationDate, vehicleConfiguration, typeOfTransport, transportDetail} = resp.data;
      this.unitTransportSelected = resp.data;
      this.unitTransportSelected!.imgUrl = this.unitTransportSelected?.img == undefined ? this.noImageUnitTransport : `${base_url}/upload/unittransports/${this.unitTransportSelected.img}`;

      this.unitTransportForm.setValue({
        plate,
        ruc,
        typeOfTransport,
        brand,
        fabricationYear,
        modelYear,
        soatExpiredDate,
        technicalReviewExpiredDate,        
        vehicleQualificationNumber,
        vehicleQualificationExpirationDate,
        vehicleConfiguration,
        additionalNotes,
        fuel,
        category: transportDetail?.category,
        model: transportDetail?.model,
        color: transportDetail?.color,
        serialNumber: transportDetail?.serialNumber,
        engineNumber: transportDetail?.engineNumber,
        bodyWork: transportDetail?.bodyWork,
        large: transportDetail?.large,
        width: transportDetail?.width,
        height: transportDetail?.height,
        axles: transportDetail?.axles
      });

      return false;
    });
  };

  saveUnitTransport() {
    let claims = this.userService.getClaimsFromLocalStorage(); 
    let userId = claims.find(f => f.type == 'Id').value.toString();
    let role = claims.find(f =>  f.type == 'Role').value.toString();

    if (!this.unitTransportSelected) {
      // Create     

      this.unitTransportForm.get('soatExpiredDate')?.setValue(!this.unitTransportForm.get('soatExpiredDate')?.value ? '1970-01-01' : this.convertDateToString(new Date(this.unitTransportForm.get('soatExpiredDate')?.value)));
      this.unitTransportForm.get('technicalReviewExpiredDate')?.setValue(!this.unitTransportForm.get('technicalReviewExpiredDate')?.value ? '1970-01-01' : this.convertDateToString(new Date(this.unitTransportForm.get('technicalReviewExpiredDate')?.value)));
      this.unitTransportForm.get('vehicleQualificationExpirationDate')?.setValue(!this.unitTransportForm.get('vehicleQualificationExpirationDate')?.value ? '1970-01-01' : this.convertDateToString(new Date(this.unitTransportForm.get('vehicleQualificationExpirationDate')?.value)));
      
      let unitTransportDetailForCreate: IUnitTransportDetail = {
        unitTransportDetailId: '00000000-0000-0000-0000-000000000000',
        category: this.unitTransportForm.get('category')?.value,
        model: this.unitTransportForm.get('model')?.value,
        color: this.unitTransportForm.get('color')?.value,
        serialNumber: this.unitTransportForm.get('serialNumber')?.value,
        engineNumber: this.unitTransportForm.get('engineNumber')?.value,
        bodyWork: this.unitTransportForm.get('bodyWork')?.value,
        large: this.unitTransportForm.get('large')?.value.toString(),
        width: this.unitTransportForm.get('width')?.value.toString(),
        height: this.unitTransportForm.get('height')?.value.toString(),
        axles: this.unitTransportForm.get('axles')?.value.toString(),
        unitTransportId: '00000000-0000-0000-0000-000000000000',
      };   
      
      let data: IUnitTransportForRegistration = {
        plate: this.unitTransportForm.get('plate')?.value,
        ruc: this.unitTransportForm.get('ruc')?.value,
        brand: this.unitTransportForm.get('brand')?.value,
        fabricationYear: this.unitTransportForm.get('fabricationYear')?.value.toString(),
        modelYear: this.unitTransportForm.get('modelYear')?.value.toString(),
        soatExpiredDate: this.unitTransportForm.get('soatExpiredDate')?.value,
        technicalReviewExpiredDate: this.unitTransportForm.get('technicalReviewExpiredDate')?.value,
        fuel: this.unitTransportForm.get('fuel')?.value,
        additionalNotes: this.unitTransportForm.get('additionalNotes')?.value,
        vehicleQualificationNumber: this.unitTransportForm.get('vehicleQualificationNumber')?.value,
        vehicleQualificationExpirationDate: this.unitTransportForm.get('vehicleQualificationExpirationDate')?.value,
        vehicleConfiguration: this.unitTransportForm.get('vehicleConfiguration')?.value,
        typeOfTransport: this.unitTransportForm.get('typeOfTransport')?.value,
        img: this.unitTransportForm.get('img')?.value,
        createdBy: '',
        unitTransportDetail: unitTransportDetailForCreate
      };      

      // const data = {
      //   ...this.unitTransportForm.value,
      //   unitTransportId: '00000000-0000-0000-0000-000000000000',    
      //   unitTransportDetail: unitTransportDetailForCreate
      // };

      // 1.- Validamos si la unidad ya se encuentra registrada
      this.unitTransportService.getUnitTransportByPlate(this.unitTransportForm.get('plate')?.value)
      .subscribe((unitTransport: any) => {
        // Validar si existe o no, en caso existe y el ruc es diferente 
        // al logueado debe de actualizar los datos un administrador
        if (unitTransport.data) {
          Swal.fire('Atencion', 'La unidad de transporte ya se encuentra registrada, debe de buscarlo y actualizar sus datos', 'info');
        }
        else {
          this.userService.getUserById(userId)
          .subscribe((userLogged: any)=> {
            if (userLogged.data.ruc != this.unitTransportForm.get('ruc')?.value && role == 'Administrator') {
              // Unidad de Transporte no existe, lo registro sin problemas.                
              this.unitTransportService.createUnitTransport(data)
              .subscribe((resp: any) => {
                Swal.fire('Creado', 'Unidad de Transporte creado correctamente', 'success'); 

                this.router.navigateByUrl(`/mantenimientos/unit-transports/${resp.unitTransportId}`);
              });
            }
            else if (userLogged.data.ruc != this.unitTransportForm.get('ruc')?.value && role != 'Administrator') {
              Swal.fire('Atencion', 'Esta intentando registrar una unidad de transporte con un ruc asociado a otra empresa, debe de enviar la tarjeta de propiedad a actualizacion_datos@sicotyc.com para realizar su registro', 'info');
            }
            else {
              // Unidad de Transporte no existe, lo registro sin problemas.                
              this.unitTransportService.createUnitTransport(data)
              .subscribe((resp: any ) => {
                Swal.fire('Creado', 'Unidad de Transporte creado correctamente', 'success');  
                
                this.router.navigateByUrl(`/mantenimientos/unit-transports/${resp.unitTransportId}`);
              })
            }
          });
        }
      });      
    }
    else {
      // Update
      this.unitTransportForm.get('soatExpiredDate')?.setValue(!this.unitTransportForm.get('soatExpiredDate')?.value ? '1970-01-01' : this.convertDateToString(new Date(this.unitTransportForm.get('soatExpiredDate')?.value)));
      this.unitTransportForm.get('technicalReviewExpiredDate')?.setValue(!this.unitTransportForm.get('technicalReviewExpiredDate')?.value ? '1970-01-01' : this.convertDateToString(new Date(this.unitTransportForm.get('technicalReviewExpiredDate')?.value)));
      this.unitTransportForm.get('vehicleQualificationExpirationDate')?.setValue(!this.unitTransportForm.get('vehicleQualificationExpirationDate')?.value ? '1970-01-01' : this.convertDateToString(new Date(this.unitTransportForm.get('vehicleQualificationExpirationDate')?.value)));
      
      let transportDetailForUpdate: IUnitTransportDetail = {
        unitTransportDetailId: this.unitTransportSelected.unitTransportDetail?.unitTransportDetailId == undefined ? '00000000-0000-0000-0000-000000000000': this.unitTransportSelected.unitTransportDetail?.unitTransportDetailId,
        category: this.unitTransportForm.get('category')?.value,
        model: this.unitTransportForm.get('model')?.value,
        color: this.unitTransportForm.get('color')?.value,
        serialNumber: this.unitTransportForm.get('serialNumber')?.value,
        engineNumber: this.unitTransportForm.get('engineNumber')?.value,
        bodyWork: this.unitTransportForm.get('bodyWork')?.value,
        large: this.unitTransportForm.get('large')?.value,
        width: this.unitTransportForm.get('width')?.value,
        height: this.unitTransportForm.get('height')?.value,
        axles: this.unitTransportForm.get('axles')?.value,
        unitTransportId: this.unitTransportSelected.unitTransportId
      };
      
      const data = {
        ...this.unitTransportForm.value,
        transportDetail: transportDetailForUpdate
      };

      this.unitTransportService.updateUnitTransport(data)
      .subscribe((resp: any) => {
        Swal.fire('Actualizado', 'Unidad de Transporte actualizado correctamente', 'success');
      });
    }
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
      .updatePhoto(this.imgUpload!, 'UNITTRANSPORTS', this.unitTransportSelected?.unitTransportId!)
      .then( img => {             
        this.unitTransportSelected!.img = img;
        this.unitTransportSelected!.imgUrl = `${base_url}/upload/drivers/${this.unitTransportSelected!.img}`;
        Swal.fire("Exito", 'Imagen de conductor actualizada', 'success');    
      })
      .catch( err => {
        console.log(err);
        Swal.fire('Error', 'No se pudo subir la imagen', 'error');
      });
  };

  formIsValid() {
    return this.unitTransportForm.invalid;
  }
  
  convertDateToString(fecha: Date): string {
    const anio = fecha.getFullYear();
    const mes = ('0' + (fecha.getMonth() + 1)).slice(-2);
    const dia = ('0' + fecha.getDate()).slice(-2);

    return `${anio}-${mes}-${dia}`;
  }; 

}
