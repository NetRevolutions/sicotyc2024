import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IncrementadorComponent } from './incrementador/incrementador.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SimuladorTinkaComponent } from './simulador-tinka/simulador-tinka.component';
import { DonaComponent } from './dona/dona.component';
import { RatingComponent } from './rating/rating.component';
import { ModalImageComponent } from './modal-image/modal-image.component';
import { PaginationComponent } from './pagination/pagination.component';
import { SearchCompanyComponent } from './search-company/search-company.component';
import { ModalCompanyComponent } from './search-company/modal-company.component';
import { TextTruncateComponent } from './text-truncate/text-truncate.component';



@NgModule({
  declarations: [
    IncrementadorComponent,
    SimuladorTinkaComponent,
    DonaComponent,
    RatingComponent,
    ModalImageComponent,
    PaginationComponent,
    SearchCompanyComponent,
    ModalCompanyComponent,
    TextTruncateComponent
  ],
  exports: [
    IncrementadorComponent,
    SimuladorTinkaComponent,
    DonaComponent,
    RatingComponent,
    ModalImageComponent,
    PaginationComponent,
    SearchCompanyComponent,
    ModalCompanyComponent,
    TextTruncateComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class ComponentsModule { }
