import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IncrementadorComponent } from './incrementador/incrementador.component';
import { FormsModule } from '@angular/forms';
import { SimuladorTinkaComponent } from './simulador-tinka/simulador-tinka.component';
import { DonaComponent } from './dona/dona.component';
import { RatingComponent } from './rating/rating.component';
import { ModalImageComponent } from './modal-image/modal-image.component';
import { PaginationComponent } from './pagination/pagination.component';
import { SearchCompanyComponent } from './search-company/search-company.component';



@NgModule({
  declarations: [
    IncrementadorComponent,
    SimuladorTinkaComponent,
    DonaComponent,
    RatingComponent,
    ModalImageComponent,
    PaginationComponent,
    SearchCompanyComponent
  ],
  exports: [
    IncrementadorComponent,
    SimuladorTinkaComponent,
    DonaComponent,
    RatingComponent,
    ModalImageComponent,
    PaginationComponent,
    SearchCompanyComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
  ]
})
export class ComponentsModule { }
