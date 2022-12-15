import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MaterialModule } from './material.module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CreateAssignmentComponent } from './Components/create-assignment/create-assignment.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './Components/login/login.component';
import { CreateStudentComponent } from './Components/create-student/create-student.component'
import { AssignmentDetailsComponent } from './Components/assignment-details/assignment-details.component'
import { AssignmentCardComponent } from './Components/assignments/assignment-card/assignment-card.component';
import { AssignmentListComponent } from './Components/assignments/assignment-list/assignment-list.component';
import { TagListComponent } from './Components/Tags/tag-list/tag-list.component';
import { TagDetailsComponent } from './Components/Tags/tag-details/tag-details.component';
import { CreateTagComponent } from './Components/Tags/create-tag/create-tag.component';
import { TagCardComponent } from './Components/Tags/tag-card/tag-card.component';

@NgModule({
    declarations: [AppComponent, CreateAssignmentComponent, AssignmentDetailsComponent, LoginComponent, CreateStudentComponent, AssignmentCardComponent, AssignmentListComponent, TagListComponent, TagDetailsComponent, CreateTagComponent, TagCardComponent],
  imports: [
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    MatInputModule,
    MaterialModule,
    MatFormFieldModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
