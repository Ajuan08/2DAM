import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ServicioLogin } from '../Servicios/servicio-login.service';

@Component({
  selector: 'login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginPageComponent {
  public error: boolean = false;
  public errorText: string | undefined;
  
  constructor(private router: Router, private ServicioLogin: ServicioLogin) {}

  irRegistro() {
    this.router.navigate(['/registro']);
  }

  login(usuario: string, contrasena: string) {
    if (usuario && contrasena) {
      if (contrasena.length >= 8) {
        if (this.ServicioLogin.login(usuario, contrasena)) {
          this.router.navigate(['/preguntas']);
        } else {
          this.error = true;
          this.errorText = "Usuario no encontrado";
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
