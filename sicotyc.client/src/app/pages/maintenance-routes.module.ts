import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

// Guards
import { AdminGuard } from '../guards/admin.guard';

// Components
import { MaintenanceComponent } from './maintenance/maintenance.component';
import { UsersComponent } from './maintenance/users/users.component';
import { UserComponent } from './maintenance/users/user.component';
import { LookupCodeGroupsComponent } from './maintenance/lookup/lookup-code-groups.component';
import { LookupCodesComponent } from './maintenance/lookup/lookup-codes.component';
import { LookupCodeComponent } from './maintenance/lookup/lookup-code.component';
import { MenuComponent } from './maintenance/menu/menu.component';
import { CompaniesComponent } from './maintenance/companies/companies.component';
import { CompanyComponent } from './maintenance/companies/company.component';
import { DriversComponent } from './maintenance/drivers/drivers.component';
import { DriverComponent } from './maintenance/drivers/driver.component';
import { UnitTransportsComponent } from './maintenance/unit-transports/unit-transports.component';
import { UnitTransportComponent } from './maintenance/unit-transports/unit-transport.component';
import { WarehousesComponent } from './maintenance/warehouses/warehouses.component';
import { WarehouseComponent } from './maintenance/warehouses/warehouse.component';
import { ZonesComponent } from './maintenance/zones/zones.component';
import { ZoneComponent } from './maintenance/zones/zone.component';

const maintenanceRoutes: Routes = [
  { path: '', component: MaintenanceComponent, data: {title: 'Mantenimientos' } },
  { path: 'users', canActivate: [AdminGuard], component: UsersComponent, data: {title: 'Usuarios de Aplicacion'}},
  { path: 'users/:id', component: UserComponent, data: {title: 'Usuario de Aplicacion'}},
  { path: 'lookupCodeGroups', component: LookupCodeGroupsComponent, data: {title: 'Lookup Code Groups'}},
  { path: 'lookupCodeGroups/lookupCodes', component: LookupCodesComponent, data: {title: 'Lookup Codes'}},
  { path: 'lookupCodeGroups/:lcgId/lookupCodes/:lcId', component: LookupCodeComponent, data: {title: 'Lookup Code'}},
  { path: 'companies', component: CompaniesComponent, data: {title: 'Empresas Registradas'}},
  { path: 'companies/:id', component: CompanyComponent, data: {title: 'Empresa'}},
  { path: 'drivers', component: DriversComponent, data: {title: 'Choferes'}},
  { path: 'drivers/:id', component: DriverComponent, data: {title: 'Chofer'}},
  { path: 'unit-transports', component: UnitTransportsComponent, data: {title: 'Unidades de Transporte'}},
  { path: 'unit-transports/:id', component: UnitTransportComponent, data: {title: 'Unidad de Transporte'}},
  { path: 'warehouses', component: WarehousesComponent, data: {title: 'Almacenes'}},
  { path: 'warehouses/:id', component: WarehouseComponent, data: {title: 'Almacen'}},
  { path: 'zones', component: ZonesComponent, data: {title: 'Zonas'}},
  { path: 'zones/:id', component: ZoneComponent, data: {title: 'Zona'}},
  { path: 'menu', component: MenuComponent, data: {title: 'Menu de la Aplicacion'}},
]


@NgModule({
  imports: [RouterModule.forChild(maintenanceRoutes)],
  exports: [RouterModule]
})
export class MaintenanceRoutesModule { }
