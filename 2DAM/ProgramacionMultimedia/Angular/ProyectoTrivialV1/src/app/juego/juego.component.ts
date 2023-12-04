import { Component } from '@angular/core';
import { PreguntasService } from 'src/services/preguntasService/preguntas.service';

@Component({
  selector: 'app-juego',
  templateUrl: './juego.component.html',
  styleUrls: ['./juego.component.css']
})
export class JuegoComponent {
  constructor(private preguntasService : PreguntasService){
    this.preguntasService.getPreguntas().subscribe(data => this.questions = data.results);
  }
  questions: any[];
  numeroPregunta: number = 0;
  question:any;
  getQuestion():any{
    this.question = this.questions[this.numeroPregunta].question;
    this.numeroPregunta++;
    return this.question;

  }
}
