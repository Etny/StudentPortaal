import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private httpClient: HttpClient) { }

  login(username: string, password: string) {
    console.log(username, password);
    return this.httpClient.post(`${environment.apiUrl}/User/login`, { username, password }).subscribe();
  }
}
