import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class CrudSchoolService {

  SchoolUrl = 'http://localhost:64492/api/School';
  ClassSchoolUrl = 'http://localhost:64492/api/ClassSchool';

  constructor(private http: HttpClient) { }

  listSchools()
  {
    return this.http.get<any[]>(`${this.SchoolUrl}`);
  }
}
