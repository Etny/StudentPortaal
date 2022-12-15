import { Component, Input } from '@angular/core';
import { Tag } from 'src/app/Models/tag';

@Component({
  selector: 'tag-card',
  templateUrl: './tag-card.component.html',
  styleUrls: ['./tag-card.component.scss']
})
export class TagCardComponent {

  @Input() tag!: Tag;

}
