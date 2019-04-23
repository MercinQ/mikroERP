import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-chart-selector',
  templateUrl: './chart-selector.component.html',
  styleUrls: ['./chart-selector.component.css']
})
export class ChartSelectorComponent implements OnInit {
  selected: string;
  chartGenderPie = false;

  constructor() { }

  ngOnInit() {
  }

  chartSelect(){
    switch(this.selected){
      case 'none': {
        this.chartGenderPie = false;
        break;
      }
      case 'option1': {
        this.chartGenderPie = true;
        break;
      }
      case 'option2': {
        // this.chartGenderPie = true;
        break;
      }
    }
  }

}
