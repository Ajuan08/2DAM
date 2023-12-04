import { Component, Input } from '@angular/core';
import { PreguntasService } from 'src/services/preguntasService/preguntas.service';

@Component({
  selector: 'app-preguntas',
  templateUrl: './preguntas.component.html',
  styleUrls: ['./preguntas.component.css']
})
export class PreguntasComponent {
 @Input() pregunta: string;
}
