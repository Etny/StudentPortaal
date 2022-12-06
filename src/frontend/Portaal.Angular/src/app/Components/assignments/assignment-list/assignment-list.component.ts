import { Component, EventEmitter } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { Assignment } from 'src/app/Models/assignment';
import { AssignmentService } from 'src/app/Services/assignment.service';

@Component({
  selector: 'app-assignment-list',
  templateUrl: './assignment-list.component.html',
  styleUrls: ['./assignment-list.component.scss']
})
export class AssignmentListComponent {

  assignments: Assignment[] = [];
  search: string = '';
  searchVal!: FormControl;

  constructor(private assignmentService: AssignmentService) {
    this.searchVal = new FormControl('');
    this.searchVal.valueChanges.subscribe(_ => this.setPhones())
    this.setPhones();
  }

  setPhones(): void {
    this.assignmentService.getAll(this.searchVal.value).subscribe(a => this.assignments = a);
  }

}
