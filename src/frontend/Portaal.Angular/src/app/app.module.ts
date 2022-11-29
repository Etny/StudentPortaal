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
import { AssignmentDetailsComponent } from './Components/assignment-details/assignment-details.component'
import { AssignmentCardComponent } from './Components/assignments/assignment-card/assignment-card.component';
import { AssignmentListComponent } from './Components/assignments/assignment-list/assignment-list.component';

@NgModule({
  declarations: [AppComponent, CreateAssignmentComponent, AssignmentDetailsComponent, AssignmentCardComponent, AssignmentListComponent],
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
