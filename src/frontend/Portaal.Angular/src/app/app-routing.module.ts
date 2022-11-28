import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AssignmentDetailsComponent } from './Components/assignment-details/assignment-details.component';
import { CreateAssignmentComponent } from './Components/create-assignment/create-assignment.component';
import { CreateStudentComponent } from './Components/create-student/create-student.component';
import { LoginComponent } from './Components/login/login.component';

const routes: Routes = [

  {
    path: 'create-assignment',
    component: CreateAssignmentComponent
  },
  {
    path: "assignment/:id",
    component: AssignmentDetailsComponent
  },
  {
    path: "login",
    component: LoginComponent
  },
  {
    path: "create-student",
    component: CreateStudentComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
