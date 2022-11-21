import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateAssignmentComponent } from './Components/create-assignment/create-assignment.component';

const routes: Routes = [

  {
    path: 'create-assignment',
    component: CreateAssignmentComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
