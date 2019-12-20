import { Component, OnInit, Inject } from '@angular/core';
import { Person } from '../person';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-persons-list',
  templateUrl: './persons-list.component.html',
  styleUrls: ['./persons-list.component.css']
})
// implements OnInit
export class PersonsListComponent {
  public persons: Person[];
  public selectedPerson: Person;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Person[]>(baseUrl + 'api/Person/Persons').subscribe(
      result => {
        this.persons = result;

        this.persons.forEach(element => {
          element.funComment = (element.age < 30)
            ? `Oh, you're young!`
            : `Oh, you're old!`;
        });
      },
      error => console.error(error)
    );
  }

  choosePerson(person: Person): void {
    this.selectedPerson = person;
  }
}
