import { Component } from '@angular/core';
import { ServicioLoginService } from '../Servicios/servicio-login.service';

@Component({
  selector: 'app-preguntas',
  templateUrl: './preguntas.component.html',
  styleUrls: ['./preguntas.component.css']
})
export class PreguntasComponent {
 usuario: string
  constructor(private ServicioLoginService: ServicioLoginService){
    this.usuario = ServicioLoginService.obtenerUsuario();
  }
}
