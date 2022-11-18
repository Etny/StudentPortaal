import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { Assignment } from 'src/app/Models/assignment.model';
import { AssignmentService } from 'src/app/Services/assignment.service';

@Component({
  selector: 'app-assignment-list',
  templateUrl: './assignment-list.component.html',
  styleUrls: ['./assignment-list.component.scss']
})
export class AssignmentListComponent {

  assignments$!: Observable<Assignment[]>

  constructor(private assignmentService: AssignmentService) {
    this.assignments$ = assignmentService.getAll();
  }

}
