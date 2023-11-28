import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { ServicioService } from './servicio.service';

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate {
  constructor(private ServicioService: ServicioService, private router: Router) {}

  canActivate(): boolean {
    if (this.ServicioService.isLoggedInUser()) {
      return true;
    } else {
      this.router.navigate(['/login']);
      return false;
    }
  }
}
