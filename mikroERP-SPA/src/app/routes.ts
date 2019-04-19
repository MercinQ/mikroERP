import { Routes } from '@angular/router';
import { ChartsComponent } from './charts/charts.component';
import { EmployeeAddComponent } from './employee-add/employee-add.component';
import { HomeComponent } from './home/home.component';
import { EmployeesTableComponent } from './employees-table/employees-table.component';

export const appRoutes: Routes = [
    { path: 'home', component: EmployeesTableComponent },
    { path: 'charts', component: ChartsComponent },
    { path: 'employee_add', component: EmployeeAddComponent },
    { path: '**', redirectTo: 'home', pathMatch: 'full'}
];
