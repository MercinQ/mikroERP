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
import { ChartsComponent } from './charts/charts.component';
import { EmployeeAddComponent } from './employee-add/employee-add.component';
import { appRoutes } from './routes';
import { HomeComponent } from './home/home.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EmployeesTableComponent } from './employees-table/employees-table.component';


@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      ChartsComponent,
      EmployeeAddComponent,
      HomeComponent,
      EmployeesTableComponent,
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
      RouterModule.forRoot(appRoutes),
   ],
   providers: [
      EmployeeService,
      MatDatepickerModule,
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
