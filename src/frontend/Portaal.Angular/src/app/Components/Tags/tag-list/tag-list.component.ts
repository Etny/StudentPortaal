import { Component } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { Tag } from 'src/app/Models/tag';
import { TagService } from 'src/app/Services/tag.service';

@Component({
  selector: 'tag-list',
  templateUrl: './tag-list.component.html',
  styleUrls: ['./tag-list.component.scss']
})
export class TagListComponent {

  tags$!: Observable<Tag[]>
  search: string = '';
  searchVal!: FormControl;

  constructor(private tagService: TagService) {
    this.searchVal = new FormControl('');
    this.searchVal.valueChanges.subscribe(_ => this.setPhones())
    this.setPhones();
  }

  setPhones(): void {
    this.tags$ = this.tagService.getAll(this.searchVal.value);
  }
}
