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
import { SidenavComponent } from './Components/homepage/sidenav/sidenav.component';
import { SidenavButtonComponent } from './Components/homepage/sidenav-button/sidenav-button.component';
import { HeaderComponent } from './Components/homepage/header/header.component';

@NgModule({
    declarations: [AppComponent, CreateAssignmentComponent, AssignmentDetailsComponent, LoginComponent, CreateStudentComponent, AssignmentCardComponent, AssignmentListComponent, SidenavComponent, SidenavButtonComponent, HeaderComponent],
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
