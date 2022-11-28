import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CreateAssignmentComponent } from './Components/create-assignment/create-assignment.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HttpClientModule } from '@angular/common/http';
import { AssignmentDetailsComponent } from './Components/assignment-details/assignment-details.component';
import { LoginComponent } from './Components/login/login.component';
import { CreateStudentComponent } from './Components/create-student/create-student.component'

@NgModule({
  declarations: [AppComponent, CreateAssignmentComponent, AssignmentDetailsComponent, LoginComponent, CreateStudentComponent],
  imports: [
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    MatInputModule,
    MatFormFieldModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
