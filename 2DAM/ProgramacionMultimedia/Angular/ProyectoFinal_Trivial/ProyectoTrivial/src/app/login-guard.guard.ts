import { CanActivate } from '@angular/router';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { ServicioLoginService } from './Servicios/servicio-login.service';

@Injectable({
  providedIn: 'root',
})
export class LoginGuard implements CanActivate {
  constructor(private router: Router, private servicioLoginService: ServicioLoginService) {}

  canActivate(): boolean {
    if (this.servicioLoginService.isLoggedInUser()) {
      return true;
    } else {
      this.router.navigate(['/login']);
      return false;
    }
  }
}
