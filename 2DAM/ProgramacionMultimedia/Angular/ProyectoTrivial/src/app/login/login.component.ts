import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from 'src/services/loginService/login.service';

@Component({
  selector: 'login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  public error: boolean = false;
  public errorText: string | undefined;
  
  constructor(private router: Router, private loginService: LoginService) {}

  irRegistro() {
    this.router.navigate(['/registro']);
  }

  login(usuario: string, contrasena: string) {
    if (usuario && contrasena) {
      if (contrasena.length >= 8) {
        if (this.loginService.login(usuario, contrasena)) {
          this.router.navigate(['/preguntas']);
        } else {
          this.error = true;
          this.errorText = "Usuario o contraseña incorrectos";
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
