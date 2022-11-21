import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Assignment } from '../Models/assignment';

@Injectable({
  providedIn: 'root'
})

export class AssignmentService {

  constructor(private httpClient: HttpClient) { }

  createAssignment(assignment: Assignment){
    console.log(assignment);
    return this.httpClient.post(`${environment.apiUrl}/Assignment/create`, assignment).subscribe();
  }
}
