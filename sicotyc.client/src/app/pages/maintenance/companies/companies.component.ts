import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';

// Interfaces
import { ICompany } from 'src/app/interfaces/company.interface';
import { IPagination } from 'src/app/interfaces/pagination.interface';

// Services
import { SearchesService } from 'src/app/services/searches.service';

@Component({
  selector: 'app-companies',
  templateUrl: './companies.component.html',
  styles: [
  ]
})
export class CompaniesComponent implements OnInit, OnDestroy {
  public loading: boolean = true;
  public pagination: IPagination = {
    pageNumber: 1,
    pageSize: 5,
    totalItems: 0
  };
  
  public companies: ICompany[] = [];
  public useSearch: boolean = false;
  public companiesSubs: Subscription = new Subscription();

  constructor(private searchesServices: SearchesService) {};
  
  ngOnInit(): void {
    this.loadCompanies();
  }; 

  ngOnDestroy(): void {
    this.companiesSubs.unsubscribe(); // Con esto evitamos fuga de memoria  
  };

  loadCompanies() {

  };

  changePage(pageNumber: number) {
    this.pagination.pageNumber = pageNumber;
    this.loadCompanies();
  };

  search(searchTerm: string) {
    
  };

}
