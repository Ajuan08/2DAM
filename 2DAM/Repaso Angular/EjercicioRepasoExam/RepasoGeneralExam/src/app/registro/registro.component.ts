import { Component } from '@angular/core';
import { LoginServicioService } from '../servicios/login-servicio.service';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent {
  public usuario: FormGroup;

  constructor(private servicioLogin: LoginServicioService, private route: Router, private formbuilder: FormBuilder ) 
  {
    this.usuario = this.formbuilder.group({
      nombre: ['', Validators.required],
      apellido: ['', [Validators.required, Validators.minLength(3)]],
      usuario: ['', Validators.required],
      contrasena: ['',[Validators.required, Validators.maxLength(8)]],
    });
   }

  irLogin() {
    this.route.navigate(['/login']);
  }

  registro(nombre: string, apellido: string, usuario: string, contrasena: string) {
    if (nombre && apellido && usuario && contrasena) {
      if (this.servicioLogin.registro(nombre, apellido, usuario, contrasena)) {
        this.route.navigate(['/login']);
      } else {
        alert("El usuario ya existe");
      }
    } else {
      alert("Debe rellenar todos los campos");
    }
  }

}
