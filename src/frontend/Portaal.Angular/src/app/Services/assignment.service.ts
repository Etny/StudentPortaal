import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
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

  getAssignment(assignmentId: number): Observable<Assignment> {
    console.log(assignmentId);
    return this.httpClient.get<Assignment>(`${environment.apiUrl}/Assignment/get/${assignmentId}`, );
  }

  getAll(filter: string): Observable<Assignment[]> {
    return this.httpClient.get<Assignment[]>(`${environment.apiUrl}/Assignment/all`, {
      params: new HttpParams().set('SearchQuery', filter)
    });
  }
  
  addComment(request: { assignmentId: number, content: string }): Observable<Comment> {
    console.log(request);
    return this.httpClient.post<Comment>(`${environment.apiUrl}/Assignment/comment`, request);
  }
}
