import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Injectable } from '@angular/core';
import { User } from '../Models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  auth_token: string = "";

  constructor(private httpClient: HttpClient) { }

  login(emailAddress: string, password: string) {
    console.log(emailAddress, password);
    return this.httpClient.post<string>(`${environment.apiUrl}/User/login`, { emailAddress, password }).subscribe(
      r => this.auth_token = r
    );
  }


  createStudent(student: User){
    console.log(student);
    return this.httpClient.post(`${environment.apiUrl}/User/create-student`, student).subscribe();
  }
}
