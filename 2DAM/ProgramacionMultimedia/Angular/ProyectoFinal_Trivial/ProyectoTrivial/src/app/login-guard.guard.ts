import { CanActivate } from '@angular/router';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { ServicioLogin } from './Servicios/servicio-login.service';
/*
@Injectable({
  providedIn: 'root',
})

export class LoginGuard implements CanActivate {
  constructor(private router: Router, private servicioLogin: ServicioLogin) {}

  
  canActivate(): boolean {
    const usuario = route.queryParams['usuario'];
    const contrasena = route.queryParams['contrasena'];

    if (this.servicioLogin.login(usuario, contrasena)) {
      return true;
    } else {
      this.router.navigate(['/login']);
      return false;
    }
  }
}

*/
