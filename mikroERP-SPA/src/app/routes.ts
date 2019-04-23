import { Routes } from '@angular/router';
import { EmployeeAddComponent } from './employee-add/employee-add.component';
import { EmployeesTableComponent } from './employees-table/employees-table.component';
import { EmployeeUpdateComponent } from './employee-update/employee-update.component';
import { ChartSelectorComponent } from './Charts/chart-selector/chart-selector.component';

export const appRoutes: Routes = [
    { path: 'home', component: EmployeesTableComponent },
    { path: 'employee_add', component: EmployeeAddComponent },
    { path: 'chart_selector', component: ChartSelectorComponent },
    { path: 'employee_update', component: EmployeeUpdateComponent },
    { path: '**', redirectTo: 'home', pathMatch: 'full'}
];
