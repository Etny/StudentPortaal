import { Component, Input } from '@angular/core';
import { Assignment } from 'src/app/Models/assignment';

@Component({
  selector: 'app-assignment-card',
  templateUrl: './assignment-card.component.html',
  styleUrls: ['./assignment-card.component.scss']
})
export class AssignmentCardComponent {

  @Input() assignment!: Assignment;

}
