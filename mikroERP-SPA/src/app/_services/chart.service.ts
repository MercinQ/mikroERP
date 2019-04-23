import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { GenderCount } from '../_models/genderCount';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ChartService {
  baseUrl = environment.apiUrl;
  constructor(private http: HttpClient) { }

  getGenderCount(): Observable<GenderCount> {
    return this.http.get<GenderCount>(this.baseUrl + 'Chart/GetGenderCount');
  }
}
