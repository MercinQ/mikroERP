import { Routes } from '@angular/router';
import { ChartsComponent } from './charts/charts.component';
import { EmployeeAddComponent } from './employee-add/employee-add.component';
import { EmployeesTableComponent } from './employees-table/employees-table.component';
import { EmployeeUpdateComponent } from './employee-update/employee-update.component';

export const appRoutes: Routes = [
    { path: 'home', component: EmployeesTableComponent },
    { path: 'charts', component: ChartsComponent },
    { path: 'employee_add', component: EmployeeAddComponent },
    { path: 'employee_update', component: EmployeeUpdateComponent },
    { path: '**', redirectTo: 'home', pathMatch: 'full'}
];
