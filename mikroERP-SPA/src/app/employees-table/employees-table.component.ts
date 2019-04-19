
import {Component, OnInit, HostListener, ViewChild} from '@angular/core';
import { Employee } from '../_models/employee';
import { EmployeeService } from '../_services/employee.service';
import { MatTableDataSource } from '@angular/material';

@Component({
  selector: 'app-employees-table',
  templateUrl: './employees-table.component.html',
  styleUrls: ['./employees-table.component.css']
})

export class EmployeesTableComponent implements OnInit {
  employees: Employee[];
  listData: MatTableDataSource<any>;
  displayedColumns: string[] = ['id'];
  constructor(private employeeService: EmployeeService) { }

  ngOnInit() {
    this.loadEmployeesToTable();
  }


  loadEmployeesToTable() {
    this.employeeService.getEmployees().subscribe((employees: Employee[]) => {
      this.employees = employees;
      console.log(employees);
    }, error => {
      console.log(error);
    });
  }
}

