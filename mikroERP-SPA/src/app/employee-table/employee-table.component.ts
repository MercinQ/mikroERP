import { Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, MatSort } from '@angular/material';
import { EmployeeTableDataSource } from './employee-table-datasource';
import { Employee } from '../_models/employee';
import { EmployeeService } from '../_services/employee.service';

@Component({
  selector: 'app-employee-table',
  templateUrl: './employee-table.component.html',
  styleUrls: ['./employee-table.component.css']
})
export class EmployeeTableComponent implements OnInit {
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;
  dataSource: EmployeeTableDataSource;
  employees: Employee[];

  /** Columns displayed in the table. Columns IDs can be added, removed, or reordered. */
  displayedColumns = ['id', 'name'];

  constructor(private employeeService: EmployeeService) {}

  ngOnInit() {
    this.loadEmployees();
    this.dataSource = new EmployeeTableDataSource(this.paginator, this.sort);
  }

  loadEmployees() {
    this.employeeService.getEmployees().subscribe((employees: Employee[]) => {
      this.employees = employees;
      console.log(employees);
    }, error => {
      console.log(error);
    });
  }
}
