import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Assignment } from 'src/app/Models/assignment';
import { AssignmentService } from 'src/app/Services/assignment.service';

@Component({
  selector: 'assignment-details',
  templateUrl: './assignment-details.component.html',
  styleUrls: ['./assignment-details.component.scss'],
})
export class AssignmentDetailsComponent {
  constructor(
    private route: ActivatedRoute,
    private assignmentService: AssignmentService
  ) {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.assignmentService.getAssignment(id).subscribe(resp => {
      this.assignment = resp;
      console.log(this.assignment);
    });
  }

  assignment!: Assignment;
}
