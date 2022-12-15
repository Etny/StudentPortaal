import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Tag } from '../Models/tag';

@Injectable({
  providedIn: 'root'
})
export class TagService {

  constructor(private httpClient: HttpClient) { }


  getAll(filter: string): Observable<Tag[]> {
    return this.httpClient.get<Tag[]>(`${environment.apiUrl}/Tag/all`, {
      params: new HttpParams().set('SearchQuery', filter)
    });
  }

  createTag(tagName: string){
    console.log(tagName);
    const config = { headers: {'Content-Type': "application/json"} };
    return this.httpClient.post(`${environment.apiUrl}/Tag/create`, `"${tagName}"`, config).subscribe();
  }
}
