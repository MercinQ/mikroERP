
import {Component, OnInit, HostListener, ViewChild} from '@angular/core';
import { Employee } from '../_models/employee';
import { EmployeeService } from '../_services/employee.service';
import { MatTableDataSource } from '@angular/material';
import { EmbeddedTemplateAst } from '@angular/compiler';
import { DataSource } from '@angular/cdk/table';

@Component({
  selector: 'app-employees-table',
  templateUrl: './employees-table.component.html',
  styleUrls: ['./employees-table.component.css']
})

export class EmployeesTableComponent implements OnInit {
  employees: Employee[];
  displayedColumns: string[] = ['id', 'firstName', 'lastName', 'sex', 'email', 'wages', 'dayOfEmployment',
   'phone', 'dateOfBirth', 'nameOfDepartment', 'roomNr', 'floorNr', 'nameOfTransport'];
  public dataSource = new MatTableDataSource<Employee>();
  constructor(private employeeService: EmployeeService) { }

  ngOnInit() {
   this.getEmployees();
  }

  public getEmployees = () => {
    this.employeeService.getEmployees()
    .subscribe(res => {
      this.dataSource.data = res as Employee[];
    });
    console.log(this.dataSource);
  }
}

