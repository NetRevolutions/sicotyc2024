export interface IUnitTransport {
    unitTransportId: string,
    unitTransportDetail?: IUnitTransportDetail,
    plate: string,
    ruc: string,
    brand: string,
    fabricationYear: string,
    modelYear: string,
    soatExpiredDate: Date,
    technicalReviewExpiredDate: Date,
    fuel: string,
    additionalNotes: string,
    vehicleQualificationNumber: string,
    vehicleQualificationExpirationDate: Date,
    vehicleConfiguration: string,
    typeOfTransport: string,
    img: string,
    imgUrl: string
};


export interface IUnitTransportForRegistration {
    plate: string,
    ruc: string,
    brand: string,
    fabricationYear: string,
    modelYear: string,
    soatExpiredDate: Date,
    technicalReviewExpiredDate: Date,
    fuel: string,
    additionalNotes: string,
    vehicleQualificationNumber: string,
    vehicleQualificationExpirationDate: Date,
    vehicleConfiguration: string,
    typeOfTransport: string,
    img: string,
    createdBy: string
    unitTransportDetail?: IUnitTransportDetail,
};

export interface IUnitTransportForUpdate {
    unitTransportId: string,
    plate: string,
    ruc: string,
    brand: string,
    fabricationYear: string,
    modelYear: string,
    soatExpiredDate: Date,
    technicalReviewExpiredDate: Date,
    fuel: string,
    additionalNotes: string,
    vehicleQualificationNumber: string,
    vehicleQualificationExpirationDate: Date,
    vehicleConfiguration: string,
    typeOfTransport: string,
    img: string,
    updatedBy: string
    unitTransportDetail?: IUnitTransportDetail,
}


export interface IUnitTransportDetail {
    unitTransportDetailId: string,
    category: string,
    model: string,
    color: string,
    serialNumber: string,
    engineNumber: string,
    bodyWork: string,
    large: number,
    width: number,
    height: number,
    axles: number,
    unitTransportId: string
}