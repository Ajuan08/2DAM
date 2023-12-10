import { Component } from '@angular/core';
import { LoginServicioService } from '../servicios/login-servicio.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent {

  constructor(private servicioLogin: LoginServicioService, private route: Router) { }

  irLogin() {
    this.route.navigate(['/login']);
  }

  registro(nombre: string, apellido: string, usuario: string, contrasena: string) {
    if (nombre && apellido && usuario && contrasena) {
      if (this.servicioLogin.registro(nombre, apellido, usuario, contrasena)) {
        this.route.navigate(['/principal']);
      } else {
        alert("El usuario ya existe");
      }
    } else {
      alert("Debe rellenar todos los campos");
    }
  }

}
