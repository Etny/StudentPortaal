import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AssignmentDetailsComponent } from './Components/assignment-details/assignment-details.component';
import { CreateAssignmentComponent } from './Components/create-assignment/create-assignment.component';

const routes: Routes = [

  {
    path: 'create-assignment',
    component: CreateAssignmentComponent
  },
  {
    path: "assignment/:id",
    component: AssignmentDetailsComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
