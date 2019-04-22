import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Employee } from '../_models/employee';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  // baseUrl = environment.apiUrl;
  baseUrl = 'http://localhost:5001/api/';

constructor(private http: HttpClient) { }

  getEmployee(id: number): Observable<Employee> {
    return this.http.get<Employee>(this.baseUrl + 'employees/' + id);
  }

  getEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(this.baseUrl + 'employees');
  }

  deleteEmployee(id: number) {
    return this.http.delete(this.baseUrl + 'employees/' + id);
  }

  addEmployee(model: any) {
    return this.http.post(this.baseUrl + 'employees', model);
  }
}
