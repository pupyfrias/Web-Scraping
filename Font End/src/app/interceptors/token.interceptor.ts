import { Router } from '@angular/router';
import { ItemService } from 'src/app/services/item.service';
import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpResponse,
} from '@angular/common/http';
import { Observable, tap } from 'rxjs';

@Injectable()
export class TokenInterceptor implements HttpInterceptor {
  constructor(private service: ItemService, private router: Router) {}

  intercept(
    request: HttpRequest<unknown>,
    next: HttpHandler
  ): Observable<HttpEvent<unknown>> {
    const encryptToken = sessionStorage.getItem('token');

    if (encryptToken) {
      const decryptToken = this.service.Decrypt(encryptToken);
      if (decryptToken.length > 0) {
        let pushToke = request.clone({
          setHeaders: {
            Authorization: `Bearer ${decryptToken}`,
          },
        });
        return next.handle(pushToke).pipe(
          tap({
            error: (error) => {
              if (error?.status === 401) {
                sessionStorage.clear();
                this.router.navigateByUrl('/login');
              }
            },
          })
        );
      }
    }

    return next.handle(request).pipe(
      tap({
        error: (error) => {
          if (error?.status === 401) {
            sessionStorage.clear();
            this.router.navigateByUrl('/login');
          }
        },
      })
    );
  }
}
