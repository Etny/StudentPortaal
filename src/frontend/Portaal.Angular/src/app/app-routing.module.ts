import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AssignmentDetailsComponent } from './Components/assignment-details/assignment-details.component';
import { AssignmentListComponent } from './Components/assignments/assignment-list/assignment-list.component';
import { CreateAssignmentComponent } from './Components/create-assignment/create-assignment.component';
import { CreateStudentComponent } from './Components/create-student/create-student.component';
import { LoginComponent } from './Components/login/login.component';
import { CreateTagComponent } from './Components/Tags/create-tag/create-tag.component';
import { TagDetailsComponent } from './Components/Tags/tag-details/tag-details.component';
import { TagListComponent } from './Components/Tags/tag-list/tag-list.component';

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
  },
  {
    path: "assignment-overview",
    component: AssignmentListComponent
  },
  {
    path: "create-tag",
    component: CreateTagComponent
  },
  {
    path: "tag/:id",
    component: TagDetailsComponent
  },
  {
    path: "tag-overview",
    component: TagListComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
