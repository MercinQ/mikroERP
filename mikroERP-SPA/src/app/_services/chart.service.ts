import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { GenderCount } from '../_models/genderCount';
import { Observable } from 'rxjs';
import { DepartmetCount } from '../_models/departmetCount';
import { DepartmentAvgEarning } from '../_models/departmentAvgEarning';
import { NumberOfEmploymentsInMonths } from '../_models/numberOfEmploymentsInMonths';

@Injectable({
  providedIn: 'root'
})
export class ChartService {
  baseUrl = environment.apiUrl;
  constructor(private http: HttpClient) { }

  getGenderCount(): Observable<GenderCount> {
    return this.http.get<GenderCount>(this.baseUrl + 'Chart/GetGenderCount');
  }

  getDepartmentCount(): Observable<DepartmetCount> {
    return this.http.get<DepartmetCount>(this.baseUrl + 'Chart/GetDepartmetsCount');
  }

  getDepartmentAvgEarnigs(): Observable<DepartmentAvgEarning> {
    return this.http.get<DepartmentAvgEarning>(this.baseUrl + 'Chart/GetDepartmetsAvgEarnings');
  }

  getNumberOfEmploymentsInMonths(): Observable<NumberOfEmploymentsInMonths> {
    return this.http.get<NumberOfEmploymentsInMonths>(this.baseUrl + 'Chart/GetNumberOfEmploymentsInMonths');
  }
}
