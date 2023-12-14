import { Component } from '@angular/core';
import { ServicioPreguntasService } from './servicio/servicio-preguntas.service';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  pregunta: string | undefined;

  constructor(private servicioPreguntas: ServicioPreguntasService) {}

  obtenerFrase() {
    this.servicioPreguntas.obtenerFrase().subscribe(data => {
      this.pregunta = data.pregunta;
    });
  }
}
