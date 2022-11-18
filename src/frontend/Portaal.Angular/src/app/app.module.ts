import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MaterialModule } from './material.module';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AssignmentListComponent } from './Components/assignments/assignment-list/assignment-list.component';
import { AssignmentCardComponent } from './Components/assignments/assignment-card/assignment-card.component';

@NgModule({
  declarations: [
    AppComponent,
    AssignmentListComponent,
    AssignmentCardComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
