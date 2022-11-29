import { Component } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { User } from 'src/app/Models/user';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'create-student',
  templateUrl: './create-student.component.html',
  styleUrls: ['./create-student.component.scss']
})
export class CreateStudentComponent {

  constructor(private userService: UserService) {

  }

  firstName = new FormControl('', [
    Validators.required,
    Validators.minLength(3),
  ]);
  lastName = new FormControl('', [
    Validators.required,
    Validators.minLength(3),
  ]);
  emailAddress = new FormControl('', [
    Validators.required,
    Validators.email
  ]);

  createStudent() {
    const user = new User();

    user.firstName = this.firstName.value!;
    user.lastName = this.lastName.value!;
    user.email = this.emailAddress.value!;
    
    this.userService.createStudent(user);
  }
}
