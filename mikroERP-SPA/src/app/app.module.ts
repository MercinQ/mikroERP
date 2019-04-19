import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { EmployeeTableComponent } from './employee-table/employee-table.component';
import { MatTableModule, MatPaginatorModule, MatSortModule, MatFormFieldModule, MatSelectModule, MatButtonModule, MatInputModule, MatNativeDateModule } from '@angular/material';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { EmployeeService } from './_services/employee.service';
import { ChartsComponent } from './charts/charts.component';
import { EmployeeAddComponent } from './employee-add/employee-add.component';
import { appRoutes } from './routes';
import { HomeComponent } from './home/home.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      EmployeeTableComponent,
      ChartsComponent,
      EmployeeAddComponent,
      HomeComponent
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
      MatDatepickerModule
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
