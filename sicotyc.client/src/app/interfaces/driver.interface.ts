export interface IDriver {
    driverId: string,
    ruc: string,
    firstName: string,
    lastName: string,
    img: string,
    documentType: string,
    documentNumber: string,
    documentExpiration: Date,  
    driverLicenses: IDriverLicense[],        
    enableIMO: boolean,
    dateOfBirth: Date,
    address: string,
    antecedentePolicialesExpiration?: Date,
    antecedentesPenalesExpiration?: Date,
    imgUrl: string
};

export interface IDriverLicense {
    driverLicenseId?: string,
    driverId?: string,        
    licenseNumber: string,        
    licenseType: string,        
    licenseExpiration: string    
};

export interface IDriverLicenseForCreation {
    driverLicenseId?: string,
    driverId?: string,        
    licenseNumber: string,        
    licenseType: string,        
    licenseExpiration: string,
    createdBy: string
};

export interface IDriverLicenseforUpdate {
    driverLicenseId?: string,
    driverId?: string,
    licenseNumber: string,        
    licenseType: string,        
    licenseExpiration: string,
    updatedBy: string
}

export interface IDriverForCreation {
    ruc: string,
    firstName: string,          
    lastName: string
    img: string,
    documentType: string,
    documentNumber: string,
    documentExpiration: Date,  
    driverLicenses: IDriverLicenseForCreation[],        
    enableIMO: boolean,
    dateOfBirth: Date,
    address: string,
    antecedentePolicialesExpiration?: Date,
    antecedentesPenalesExpiration?: Date
    createdBy: string
};

export interface IDriverForUpdate {
    driverId: string,
    ruc: string,
    firstName: string,
    lastName: string,
    img: string,
    documentType: string,
    documentNumber: string,
    documentExpiration: Date,  
    driverLicenses: IDriverLicenseforUpdate[],        
    enableIMO: boolean,
    dateOfBirth: Date,
    address: string,
    antecedentePolicialesExpiration?: Date,
    antecedentesPenalesExpiration?: Date,
    updatedBy: string   
}
