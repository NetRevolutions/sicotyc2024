import { AfterViewInit, Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';
import { Chart } from 'chart.js';
import { ChartData, ChartEvent, ChartType } from 'chart.js';

@Component({
  selector: 'app-dona',
  templateUrl: 'dona.component.html',
  styleUrls: [],
})
export class DonaComponent implements OnInit, AfterViewInit{  
  @ViewChild('myChart') myChart!: ElementRef;

  @Input() title: string = 'Sin titulo';
  @Input('labels') doughnutChartLabels: string[] = [];
  @Input('data') dataDonut: number[] = [];
  @Input('backgroundColor') backgroundColorDonut: string[] = [];
  @Input('borderColor') borderColorDonut: string[] = [];
  @Input('borderWith') borderWithDonut: number = 1;
  @Input() donutResponsive: boolean = true;
  @Input() donutMaintainAspectRatio: boolean = false;

  charOptions = {
    resposive: this.donutResponsive,
    maintainAspectRatio: this.donutMaintainAspectRatio
  }; 

  constructor() {
    // Valores por defecto en caso no se setee nada desde otros componentes
    this.dataDonut = [350, 450, 100];
    this.doughnutChartLabels = ['Labels1', 'Labels2', 'Labels3'];
    this.backgroundColorDonut = ['#6857E6', '#009FEE', '#F02059'];    
  }
  ngAfterViewInit(): void {
    const ctx = this.myChart.nativeElement.getContext('2d');

    const myChart = new Chart(ctx, {
      type: this.doughnutChartType,
      data: {
        labels: this.doughnutChartLabels,
        datasets: [{
          label: '',
          data: this.dataDonut,
          backgroundColor: this.backgroundColorDonut,
          borderColor: this.borderColorDonut,
          borderWidth: this.borderWithDonut
        }]
      },
      options: {
        responsive: this.donutResponsive,
        plugins: {
          legend: {
            position: 'top'
          },
          title: {
            display: true,
            text: this.title
          }
        }
      }
    });
  }

  ngOnInit(): void {
    // Aca seteamos los valores que vienen como @Input() al objeto doughnutChartData
    // this.doughnutChartData.datasets[0].data = this.dataDonut;
    // this.doughnutChartData.datasets[0].backgroundColor = this.backgroundColorDonut;
    // this.doughnutChartData.labels = this.doughnutChartLabels;
  }


  // Doughnut
  // public doughnutChartLabels: string[] = [
  //   'Download Sales',
  //   'In-Store Sales',
  //   'Mail-Order Sales',
  // ];

  // public doughnutChartData: ChartData<'doughnut'> = {
  //   labels: this.doughnutChartLabels,
  //   datasets: [
  //     {
  //       data: this.dataDonut,
  //       backgroundColor: this.backgroundColorDonut
  //     }
  //     // { data: [350, 450, 100] },
  //     // { data: [50, 150, 120] },
  //     // { data: [250, 130, 70] },
  //   ],
  // };
  public doughnutChartType: ChartType = 'doughnut';

  // events
  public chartClicked({
    event,
    active,
  }: {
    event: ChartEvent;
    active: object[];
  }): void {
    //console.log(event, active);
  }

  public chartHovered({
    event,
    active,
  }: {
    event: ChartEvent;
    active: object[];
  }): void {
    //console.log(event, active);
  }
}