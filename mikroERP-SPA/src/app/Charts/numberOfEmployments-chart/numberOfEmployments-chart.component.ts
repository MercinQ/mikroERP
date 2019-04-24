import { Component, OnInit } from '@angular/core';
import { NumberOfEmploymentsInMonths } from 'src/app/_models/numberOfEmploymentsInMonths';
import { ChartService } from 'src/app/_services/chart.service';
import { Chart } from 'chart.js';

@Component({
  selector: 'app-number-of-employments-chart',
  templateUrl: './numberOfEmployments-chart.component.html',
  styleUrls: ['./numberOfEmployments-chart.component.css']
})
export class NumberOfEmploymentsChartComponent implements OnInit {
  LineChart = [];
  nrOfEmpInMonths: NumberOfEmploymentsInMonths;
  constructor(private chartService: ChartService) { }

  ngOnInit() {
    this.getNumberOfEmploymentsInMonths();
  }

  getNumberOfEmploymentsInMonths() {
    this.chartService.getNumberOfEmploymentsInMonths().subscribe((numberOfEmploymentsInMonths: NumberOfEmploymentsInMonths) => {
    this.nrOfEmpInMonths = numberOfEmploymentsInMonths;
    this.LineChart = new Chart('lineChart', {
      type: 'line',
    data: {
     labels: ['Jan', 'Feb', 'March', 'April', 'May', 'June', 'July', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],
     datasets: [{
         label: 'Number of Employments per Month',
         data: [this.nrOfEmpInMonths.employedInJan, this.nrOfEmpInMonths.employedInFeb
           , this.nrOfEmpInMonths.employedInMarch, this.nrOfEmpInMonths.employedInApril,
           this.nrOfEmpInMonths.employedInMay, this.nrOfEmpInMonths.employedInJune,
            this.nrOfEmpInMonths.employedInJuly, this.nrOfEmpInMonths.employedInAug,
             this.nrOfEmpInMonths.employedInSep, this.nrOfEmpInMonths.employedInOct,
             this.nrOfEmpInMonths.employedInNov , this.nrOfEmpInMonths.employedInDec],
         fill: false,
         lineTension: 0.2,
         borderColor: 'red',
         borderWidth: 1
     }]
    },
    options: {
     title: {
         text: 'Number of Employments In Months',
         display: true
     },
     scales: {
         yAxes: [{
             ticks: {
                 beginAtZero: true
             }
         }]
     }
    }
    });
    }, error => {
      console.log(error);
    });
  }

}
