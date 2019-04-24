import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-chart-selector',
  templateUrl: './chart-selector.component.html',
  styleUrls: ['./chart-selector.component.css']
})
export class ChartSelectorComponent implements OnInit {
  selected: string;
  chartGenderPie = false;
  chartDepartmentBar = false;
  chartDepartmentAvg = false;
  chartNumberOfEmployments = false;
  constructor() { }

  ngOnInit() {
  }

  chartSelect() {
    switch (this.selected) {
      case 'none': {
        this.chartGenderPie = false;
        this.chartDepartmentBar = false;
        this.chartDepartmentAvg = false;
        this.chartNumberOfEmployments = false;
        break;
      }
      case 'option1': {
        this.chartGenderPie = true;
        this.chartDepartmentBar = false;
        this.chartDepartmentAvg = false;
        this.chartNumberOfEmployments = false;
        break;
      }
      case 'option2': {
         this.chartDepartmentBar = true;
         this.chartGenderPie = false;
         this.chartDepartmentAvg = false;
         this.chartNumberOfEmployments = false;
         break;
      }
      case 'option3': {
        this.chartDepartmentAvg = true;
        this.chartDepartmentBar = false;
        this.chartGenderPie = false;
        this.chartNumberOfEmployments = false;
        break;
     }
     case 'option4': {
      this.chartNumberOfEmployments = true;
      this.chartDepartmentAvg = false;
      this.chartDepartmentBar = false;
      this.chartGenderPie = false;
      break;
   }
    }
  }

}
