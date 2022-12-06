import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
import * as moment from 'moment';
import { Assignment } from 'src/app/Models/assignment';

@Component({
  selector: 'app-assignment-card',
  templateUrl: './assignment-card.component.html',
  styleUrls: ['./assignment-card.component.scss']
})
export class AssignmentCardComponent {

  @Input() assignment!: Assignment;

  constructor(private router: Router) { }

  createdString(): string {
    return moment(this.assignment.dateCreated).fromNow();
  }

  onClick() {
    this.router.navigateByUrl(`assignment/${this.assignment.id}`)
  }

}
