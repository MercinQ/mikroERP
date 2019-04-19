import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee-add',
  templateUrl: './employee-add.component.html',
  styleUrls: ['./employee-add.component.css']
})
export class EmployeeAddComponent implements OnInit {
  model: any = {};

  constructor() { }

  ngOnInit() {
  }

  addEmployee(){
    console.log(this.model);
  }

}
