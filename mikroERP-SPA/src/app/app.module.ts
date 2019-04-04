import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { EmployeeTableComponent } from './employee-table/employee-table.component';
import { MatTableModule, MatPaginatorModule, MatSortModule } from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { EmployeeService } from './_services/employee.service';

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      EmployeeTableComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      MatTableModule,
      MatPaginatorModule,
      MatSortModule,
      BrowserAnimationsModule,
      HttpClientModule
   ],
   providers: [
      EmployeeService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
