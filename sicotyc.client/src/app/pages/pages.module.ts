import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

// Modulos
import { SharedModule } from '../shared/shared.module';
import { ComponentsModule } from '../components/components.module';
import { PipesModule } from '../pipes/pipes.module';

// Componentes
import { DashboardComponent } from './dashboard/dashboard.component';
import { Grafica1Component } from './dashboard/grafica1/grafica1.component';
import { PagesComponent } from './pages.component';
import { ProgressComponent } from './dashboard/progress/progress.component';
import { JuegosAzarComponent } from './dashboard/juegos-azar/juegos-azar.component';
import { AccountSettingsComponent } from './account-settings/account-settings.component';
import { PromesasComponent } from './promesas/promesas.component';
import { RxjsComponent } from './rxjs/rxjs.component';
import { ProfileComponent } from './profile/profile.component';
import { UsersComponent } from './maintenance/users/users.component';
import { MaintenanceComponent } from './maintenance/maintenance.component';
import { UserComponent } from './maintenance/users/user.component';
import { LookupCodeGroupsComponent } from './maintenance/lookup/lookup-code-groups.component';
import { LookupCodesComponent } from './maintenance/lookup/lookup-codes.component';
import { LookupCodeComponent } from './maintenance/lookup/lookup-code.component';
import { SearchComponent } from './search/search.component';
import { MenuComponent } from './maintenance/menu/menu.component';
import { CompaniesComponent } from './maintenance/companies/companies.component';
import { CompanyComponent } from './maintenance/companies/company.component';
import { DriversComponent } from './maintenance/drivers/drivers.component';
import { DriverComponent } from './maintenance/drivers/driver.component';
import { UnitTransportsComponent } from './maintenance/unit-transports/unit-transports.component';
import { UnitTransportComponent } from './maintenance/unit-transports/unit-transport.component';


@NgModule({
  declarations: [
    DashboardComponent,
    ProgressComponent,
    Grafica1Component,
    PagesComponent,
    JuegosAzarComponent,
    AccountSettingsComponent,
    PromesasComponent,
    RxjsComponent,
    ProfileComponent,
    UsersComponent,
    MaintenanceComponent,
    UserComponent,
    LookupCodeGroupsComponent,
    LookupCodesComponent,
    LookupCodeComponent,
    SearchComponent,
    MenuComponent,
    CompaniesComponent,
    CompanyComponent,
    DriversComponent,
    DriverComponent,
    UnitTransportsComponent,
    UnitTransportComponent    
  ],
  exports: [
    DashboardComponent,
    ProgressComponent,
    Grafica1Component,
    PagesComponent,
    AccountSettingsComponent,
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule,    
    SharedModule,
    ComponentsModule,
    PipesModule
  ],
})
export class PagesModule { }
