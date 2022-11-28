import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Injectable } from '@angular/core';
import { User } from '../Models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private httpClient: HttpClient) { }

  login(emailAddress: string, password: string) {
    console.log(emailAddress, password);
    return this.httpClient.post(`${environment.apiUrl}/User/login`, { emailAddress, password }).subscribe();
  }


  createStudent(student: User){
    console.log(student);
    return this.httpClient.post(`${environment.apiUrl}/User/create-student`, student).subscribe();
  }
}
