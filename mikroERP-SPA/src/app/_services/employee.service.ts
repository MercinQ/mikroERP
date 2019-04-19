import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Employee } from '../_models/employee';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  baseUrl = environment.apiUrl;
constructor(private http: HttpClient) { }

  getEmployee(id: number): Observable<Employee> {
    return this.http.get<Employee>(this.baseUrl + 'employees/' + id);
  }

  getEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(this.baseUrl + 'employees');
  }

}
