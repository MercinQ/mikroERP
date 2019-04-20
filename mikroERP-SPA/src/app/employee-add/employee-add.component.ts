import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../_services/employee.service';

@Component({
  selector: 'app-employee-add',
  templateUrl: './employee-add.component.html',
  styleUrls: ['./employee-add.component.css']
})
export class EmployeeAddComponent implements OnInit {
  model: any = {};

  constructor(private employeeService: EmployeeService) { }

  ngOnInit() {
  }

  addEmployee(){
    console.log(this.model);
    this.employeeService.addEmployee(this.model).subscribe(() => {
      console.log('Employee added');
    }, error => {
      console.log(error);
    });
  }
}
