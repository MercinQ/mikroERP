import { Component, OnInit } from '@angular/core';
import { ChartService } from 'src/app/_services/chart.service';
import { DepartmetCount } from 'src/app/_models/departmetCount';

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
  }

  getDepartmentCount() {
    this.chartService.getDepartmentCount().subscribe((departmentCount: DepartmetCount) => {
      this.departmentCount = departmentCount;
    }, error => {
      console.log(error);
    });
  }
}
