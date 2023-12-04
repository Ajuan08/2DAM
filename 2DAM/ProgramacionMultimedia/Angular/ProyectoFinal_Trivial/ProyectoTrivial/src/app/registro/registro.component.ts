import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ServicioLogin } from '../Servicios/servicio-login.service';

@Component({
  selector: 'app-signup-page',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent {
  public error: boolean = false;
  public errorText: string | undefined;

  constructor(private router: Router, private servicioLogin: ServicioLogin) {}

  irLogin() {
    this.router.navigate(['/login']);
  }

  registro(usuario: string, contrasena: string) {
    if (usuario && contrasena) {
      if (contrasena.length >= 8) {
        if (this.servicioLogin.login(usuario, contrasena)) {
          this.router.navigate(['/login']);
        } else {
          this.error = true;
          this.errorText = "Este usuario ya existe";
        }
      } else {
        this.error = true;
        this.errorText = "Introduzca una contraseña de 8 caracteres como mínimo";
      }
    } else {
      this.error = true;
      this.errorText = "Rellene todos los campos";
    }
  }
}
