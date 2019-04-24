import { Component, OnInit } from '@angular/core';
import { DepartmentAvgEarning } from 'src/app/_models/departmentAvgEarning';
import { ChartService } from 'src/app/_services/chart.service';
import { Chart } from 'chart.js';

@Component({
  selector: 'app-department-avg-earning-chart',
  templateUrl: './departmentAvgEarning-chart.component.html',
  styleUrls: ['./departmentAvgEarning-chart.component.css']
})
export class DepartmentAvgEarningChartComponent implements OnInit {
  BarChart = [];
  departmentAvgEarnings: DepartmentAvgEarning;
  constructor(private chartService: ChartService) { }

  ngOnInit() {
    this.getDepartmentAvgEarning();
  }

  getDepartmentAvgEarning() {
    this.chartService.getDepartmentAvgEarnigs().subscribe((departmentAvgEarnings: DepartmentAvgEarning) => {
      this.departmentAvgEarnings = departmentAvgEarnings;
      this.BarChart = new Chart('barChart', {
        type: 'bar',
      data: {
       labels: ['Management', 'Logistics Department', 'Administration Department', 'Marketing department'],
       datasets: [{
           label: 'Earnings',
           data: [departmentAvgEarnings.managmentAvgEarnings, departmentAvgEarnings.logisticAvgEarnings,
             departmentAvgEarnings.administrationAvgEarnings, departmentAvgEarnings.marketingAvgEarnings],
           backgroundColor: [
               'rgba(255, 153, 0, 0.2)',
               'rgba(102, 102, 255, 0.2)',
               'rgba(102, 0, 51, 0.2)',
               'rgba(102, 153, 255, 0.2)'
           ],
           borderColor: [
               'rgba(255, 153, 0, 1)',
               'rgba(102, 102, 255, 1)',
               'rgba(102, 0, 51, 1)',
               'rgba(102, 153, 255, 1)'
           ],
           borderWidth: 1
       }]
      },
      options: {
       title: {
           text: 'Department Earnings Chart',
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
