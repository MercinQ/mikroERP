import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../_services/employee.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-employee-add',
  templateUrl: './employee-add.component.html',
  styleUrls: ['./employee-add.component.css']
})
export class EmployeeAddComponent implements OnInit {
  model: any = {};

  constructor(private employeeService: EmployeeService, private alertify: AlertifyService) { }

  ngOnInit() {
  }

  addEmployee() {
    console.log(this.model);
    this.employeeService.addEmployee(this.model).subscribe(() => {
      this.alertify.success('Employee added');
    }, error => {
      console.log(error);
    });
  }
}
