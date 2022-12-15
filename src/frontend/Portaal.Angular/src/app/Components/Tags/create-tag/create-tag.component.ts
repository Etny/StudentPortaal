import { Component } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { TagService } from 'src/app/Services/tag.service';

@Component({
  selector: 'create-tag',
  templateUrl: './create-tag.component.html',
  styleUrls: ['./create-tag.component.scss']
})
export class CreateTagComponent {

  constructor(private tagService: TagService) {

  }

  tagName = new FormControl('', [
    Validators.required,
    Validators.minLength(2),
  ]);

  createTag() {
    this.tagService.createTag(this.tagName.value!);
  }
}
