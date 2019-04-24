import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { MatTableModule, MatPaginatorModule, MatSortModule, MatFormFieldModule } from '@angular/material';
import { MatSelectModule, MatButtonModule, MatInputModule, MatNativeDateModule} from '@angular/material';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { EmployeeService } from './_services/employee.service';
import { ChartsComponent } from './Charts/genderChart/charts.component';
import { EmployeeAddComponent } from './employee-add/employee-add.component';
import { appRoutes } from './routes';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EmployeesTableComponent } from './employees-table/employees-table.component';
import { AlertifyService } from './_services/alertify.service';
import { ChartService } from './_services/chart.service';
import { EmployeeUpdateComponent } from './employee-update/employee-update.component';
import { ChartSelectorComponent } from './Charts/chart-selector/chart-selector.component';
import { DepartmentChartComponent } from './Charts/department-chart/department-chart.component';
import { DepartmentAvgEarningChartComponent } from './Charts/departmentAvgEarning-chart/departmentAvgEarning-chart.component';





@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      ChartsComponent,
      EmployeeAddComponent,
      EmployeesTableComponent,
      EmployeeUpdateComponent,
      ChartSelectorComponent,
      DepartmentChartComponent,
      DepartmentAvgEarningChartComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      MatTableModule,
      MatPaginatorModule,
      MatSortModule,
      MatFormFieldModule,
      MatSelectModule,
      MatButtonModule,
      MatInputModule,
      MatDatepickerModule,
      MatNativeDateModule,
      ReactiveFormsModule,
      FormsModule,
      BrowserAnimationsModule,
      HttpClientModule,
      RouterModule.forRoot(appRoutes)
   ],
   providers: [
      EmployeeService,
      MatDatepickerModule,
      AlertifyService,
      ChartService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
