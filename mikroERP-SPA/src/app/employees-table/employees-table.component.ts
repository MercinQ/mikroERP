
import {Component, OnInit, HostListener, ViewChild} from '@angular/core';
import { Employee } from '../_models/employee';
import { EmployeeService } from '../_services/employee.service';
import { MatTableDataSource, MatPaginator, MatSort } from '@angular/material';
import { EmbeddedTemplateAst } from '@angular/compiler';
import { DataSource } from '@angular/cdk/table';

@Component({
  selector: 'app-employees-table',
  templateUrl: './employees-table.component.html',
  styleUrls: ['./employees-table.component.css']
})

export class EmployeesTableComponent implements OnInit {
  employees: Employee[];
  displayedColumns: string[] = ['id', 'firstName', 'lastName', 'sex', 'wages', 'dayOfEmployment',
   'phone', 'dateOfBirth', 'nameOfDepartment', 'roomNr', 'floorNr', 'nameOfTransport', 'email'];
  public dataSource = new MatTableDataSource<Employee>();
  constructor(private employeeService: EmployeeService) { }
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  ngOnInit() {
   this.getEmployees();
   this.dataSource.paginator = this.paginator;
   this.dataSource.sort = this.sort;
  }

  public getEmployees = () => {
    this.employeeService.getEmployees()
    .subscribe(res => {
      this.dataSource.data = res as Employee[];
    });
  }
}

