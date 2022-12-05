import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { UserService } from 'src/app/Services/user.service';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {

  constructor(private userService: UserService) {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    if(request.url.includes(environment.apiUrl) 
    && !request.headers.has('Authorization')
    && this.userService.auth_token) {
      request = request.clone({headers: request.headers.append('Authorization', `Bearer ${this.userService.auth_token}`)})
    }

    return next.handle(request);
  }
}
