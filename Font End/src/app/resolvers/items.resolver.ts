import { catchError } from 'rxjs/operators';
import { ItemService } from 'src/app/services/item.service';
import { Injectable } from '@angular/core';
import {
  ActivatedRouteSnapshot,
  Resolve,
  Router,
  RouterStateSnapshot,
} from '@angular/router';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ItemsResolver implements Resolve<Observable<boolean>> {
  constructor(private service: ItemService, private router:Router) {}

  resolve(): Observable<boolean> {
    console.log('resolve',window.location.href)
    return this.service.GetRequest()
    .pipe(
      catchError((error) => {
        this.service.ShowError(error);
        return of(false);
      })
    );
  }
}
