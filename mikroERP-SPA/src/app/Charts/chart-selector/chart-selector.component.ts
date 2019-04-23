import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-chart-selector',
  templateUrl: './chart-selector.component.html',
  styleUrls: ['./chart-selector.component.css']
})
export class ChartSelectorComponent implements OnInit {
  selected: string;
  constructor() { }

  ngOnInit() {
  }

}
