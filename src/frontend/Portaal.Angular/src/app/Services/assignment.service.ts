import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Assignment } from '../Models/assignment.model';

@Injectable({
  providedIn: 'root'
})
export class AssignmentService {

  private assigments: Assignment[] = [
    {id: 0, title: 'Make a student portal', summary: 'Please make a student portal for us 😋', tags: ['C#', 'ASP.Net Core', 'Angular']},
    {id: 1, title: 'Fix the Github not working', summary: 'Why can\'t some contributors push to the repo 🤨? You don\'t know, and neither do we!', tags: ['Github', 'Debugging']},
    {id: 2, title: 'Sort out the board', summary: 'There\'s a list of BI\'s on the board, do something with them 🤷', tags: ['Organization']},
  ]

  constructor() { }

  getAll(): Observable<Assignment[]> {
    return of(this.assigments)
  }
}
