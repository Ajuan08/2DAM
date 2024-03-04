import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-respuesta',
  templateUrl: './respuesta.component.html',
  styleUrls: ['./respuesta.component.css']
})
export class RespuestaComponent {
  @Input() respuesta: string;
  @Output() respuestaSeleccionada = new EventEmitter<string>();
  @Output() obtenerSiguientePregunta = new EventEmitter<boolean>();

  respuestas: boolean;

  seleccionarRespuesta() {
    if (!this.respuestas) {
      this.respuestaSeleccionada.emit(this.respuesta);
      this.respuestas = true;
    }
  }

  obtenerSiguientePreguntaTrivial() {
    this.respuestas = false;
    this.obtenerSiguientePregunta.emit(true);
  }
}
