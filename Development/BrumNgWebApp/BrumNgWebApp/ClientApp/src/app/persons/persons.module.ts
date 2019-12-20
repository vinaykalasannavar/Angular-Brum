import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PersonsRoutingModule } from './/persons-routing.module';
import { PersonComponent } from './person/person.component';
import { PersonsListComponent } from './persons-list/persons-list.component';
import { PersonsComponent } from './persons.component';

@NgModule({
  imports: [
    CommonModule,
    PersonsRoutingModule
  ],
  declarations: [PersonComponent, PersonsListComponent, PersonsComponent]
})
export class PersonsModule { }
