import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../_services/employee.service';
import { AlertifyService } from '../_services/alertify.service';
import { NgModel } from '@angular/forms';

@Component({
  selector: 'app-employee-update',
  templateUrl: './employee-update.component.html',
  styleUrls: ['./employee-update.component.css']
})
export class EmployeeUpdateComponent implements OnInit {

  model: any = {};
  employeeId: any;
  NameOfEditedEmployee: string;

  constructor(private employeeService: EmployeeService, private alertify: AlertifyService) { }


  ngOnInit() {
    this.employeeId = this.employeeService.getEmployeeId();
    this.getEmployee();
  }

  public getEmployee = () => {

    this.employeeService.getEmployee(this.employeeId)
    .subscribe(model => {
      this.model = model;
      this.setSubIdToString(this.model);
      this.NameOfEditedEmployee = this.model.firstName + ' ' + this.model.lastName;
      this.alertify.message('Edit ' + this.NameOfEditedEmployee);
      console.log(this.model);
    }, error => {
      this.alertify.error(error);
      console.log(error);
    });
  }

  updateEmployee(rowId: number) {
    console.log(this.model);
    this.employeeService.updateEmployee(this.model).subscribe(() => {
      this.alertify.success('Edit completed');
    }, error => {
      this.alertify.error(error);
    });
  }

  setSubIdToString(model: any) {
    switch (model.departmentId) {
      case 1: {
        model.departmentId = '1';
        break;
      }
      case 2: {
        model.departmentId = '2';
        break;
      }
      case 3: {
        model.departmentId = '3';
        break;
      }
      case 4: {
        model.departmentId = '4';
        break;
      }
    }
    switch (model.transportId) {
      case 1: {
        model.transportId = '1';
        break;
      }
      case 2: {
        model.transportId = '2';
        break;
      }
      case 3: {
        model.transportId = '3';
        break;
      }
      case 4: {
        model.transportId = '4';
        break;
      }
      case 5: {
        model.transportId = '5';
        break;
      }
      case 6: {
        model.transportId = '6';
        break;
      }
    }
  }
}
