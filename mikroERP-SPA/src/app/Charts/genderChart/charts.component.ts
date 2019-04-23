import { Component, OnInit } from '@angular/core';
import { ChartService } from '../../_services/chart.service';
import { GenderCount } from '../../_models/genderCount';
import { Chart } from 'chart.js';

@Component({
  selector: 'app-gender-chart',
  templateUrl: './charts.component.html',
  styleUrls: ['./charts.component.css']
})
export class ChartsComponent implements OnInit {

  PieChart = [];
  genderCount: GenderCount;
  selected: number;
  GenderPieChart = false;

  constructor(private chartService: ChartService) { }

  ngOnInit() {
    this.getGenderCount();
  }

   getGenderCount() {
    this.chartService.getGenderCount().subscribe((genderCount: GenderCount) => {
      this.genderCount = genderCount;
      this.PieChart = new Chart('pieChart', {
        type: 'pie',
      data: {
       labels: ['Man', 'Woman'],
       datasets: [{
           data: [genderCount.menCount, genderCount.womanCount],
           backgroundColor: [
               'rgba(255, 99, 132, 0.2)',
               'rgba(54, 162, 235, 0.2)'
           ],
           borderColor: [
               'rgba(255,99,132,1)',
               'rgba(54, 162, 235, 1)'
           ],
           borderWidth: 1
       }]
      },
      options: {
       title: {
           text: 'Employees Genders',
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
