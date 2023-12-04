import { Component } from '@angular/core';
import { ServicioLogin } from '../Servicios/servicio-login.service';

@Component({
  selector: 'app-preguntas',
  templateUrl: './preguntas.component.html',
  styleUrls: ['./preguntas.component.css']
})
export class PreguntasComponent {
 //usuario: string
  constructor(private ServicioLogin: ServicioLogin){
    //this.usuario = ServicioLogin.obtenerUsuario();
  }
}
