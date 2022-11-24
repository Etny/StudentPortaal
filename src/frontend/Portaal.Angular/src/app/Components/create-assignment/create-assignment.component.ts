import { Component } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { Assignment } from 'src/app/Models/assignment';
import { Tag } from 'src/app/Models/tag';
import { AssignmentService } from 'src/app/Services/assignment.service';

@Component({
  selector: 'create-assignment',
  templateUrl: './create-assignment.component.html',
  styleUrls: ['./create-assignment.component.scss'],
})
export class CreateAssignmentComponent {

  constructor(private assignmentService: AssignmentService) {

  }

  titleForm = new FormControl('', [
    Validators.required,
    Validators.minLength(3),
  ]);
  summaryForm = new FormControl('', [
    Validators.required,
    Validators.minLength(3),
  ]);
  tagsForm = new FormControl('', [
    Validators.required,
    Validators.minLength(3),
  ]);

  createAssignment() {
    const newAssignment = new Assignment();
    

    newAssignment.title = this.titleForm.value!,
    newAssignment.description = this.summaryForm.value!,

    this.tagsForm.value?.split(',').forEach(element => {
      const newTag = new Tag();
      newTag.name = element;
      newAssignment.tags.push(newTag);
    });
    
    this.assignmentService.createAssignment(newAssignment);
  }
}
