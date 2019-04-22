
import {Component, OnInit, HostListener, ViewChild} from '@angular/core';
import { Employee } from '../_models/employee';
import { EmployeeService } from '../_services/employee.service';
import { MatTableDataSource, MatPaginator } from '@angular/material';
import { EmbeddedTemplateAst } from '@angular/compiler';
import { DataSource } from '@angular/cdk/table';

@Component({
  selector: 'app-employees-table',
  templateUrl: './employees-table.component.html',
  styleUrls: ['./employees-table.component.css']
})

export class EmployeesTableComponent implements OnInit {
  @ViewChild(MatPaginator) paginator: MatPaginator;
  employees: Employee[];
  displayedColumns: string[] = ['id', 'firstName', 'lastName', 'sex', 'wages', 'dayOfEmployment',
   'phone', 'dateOfBirth', 'nameOfDepartment', 'roomNr', 'floorNr', 'nameOfTransport', 'email'];
  public dataSource = new MatTableDataSource<Employee>();
  constructor(private employeeService: EmployeeService) { }

  ngOnInit() {
   this.getEmployees();
   this.dataSource.paginator = this.paginator;
  }

  public getEmployees = () => {
    this.employeeService.getEmployees()
    .subscribe(res => {
      this.dataSource.data = res as Employee[];
    });
  }
}

