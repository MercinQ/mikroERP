import { Routes } from '@angular/router';
import { EmployeeTableComponent } from './employee-table/employee-table.component';
import { ChartsComponent } from './charts/charts.component';
import { EmployeeAddComponent } from './employee-add/employee-add.component';
import { HomeComponent } from './home/home.component';

export const appRoutes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'employee_table', component: EmployeeTableComponent },
    { path: 'charts', component: ChartsComponent },
    { path: 'employee_add', component: EmployeeAddComponent },
    { path: '**', redirectTo: 'home', pathMatch: 'full'}
]
