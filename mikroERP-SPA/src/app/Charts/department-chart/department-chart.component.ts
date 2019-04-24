import { Component, OnInit } from '@angular/core';
import { ChartService } from 'src/app/_services/chart.service';
import { DepartmetCount } from 'src/app/_models/departmetCount';
import { Chart } from 'chart.js';

@Component({
  selector: 'app-department-chart',
  templateUrl: './department-chart.component.html',
  styleUrls: ['./department-chart.component.css']
})
export class DepartmentChartComponent implements OnInit {
  BarChart = [];
  departmentCount: DepartmetCount;
  constructor(private chartService: ChartService) { }
  ngOnInit() {
    this.getDepartmentCount();
  }

  getDepartmentCount() {
    this.chartService.getDepartmentCount().subscribe((departmentCount: DepartmetCount) => {
      this.departmentCount = departmentCount;
      this.BarChart = new Chart('barChart', {
        type: 'bar',
      data: {
       labels: ['Management', 'Logistics Department', 'Administration Department', 'Marketing department'],
       datasets: [{
           label: 'Employees',
           data: [this.departmentCount.managmentDepCount, this.departmentCount.logisticsDepCount,
             this.departmentCount.administrationDepCount, this.departmentCount.marketingDepCount],
           backgroundColor: [
               'rgba(255, 99, 132, 0.2)',
               'rgba(54, 162, 235, 0.2)',
               'rgba(255, 206, 86, 0.2)',
               'rgba(75, 192, 192, 0.2)'
           ],
           borderColor: [
               'rgba(255,99,132,1)',
               'rgba(54, 162, 235, 1)',
               'rgba(255, 206, 86, 1)',
               'rgba(75, 192, 192, 1)'
           ],
           borderWidth: 1
       }]
      },
      options: {
       title: {
           text: 'Department Chart',
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
