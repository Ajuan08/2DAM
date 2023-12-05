import { Component } from '@angular/core';
import { map } from 'rxjs';
import { PreguntasService } from 'src/services/preguntasService/preguntas.service';

@Component({
  selector: 'app-juego',
  templateUrl: './juego.component.html',
  styleUrls: ['./juego.component.css']
})
export class JuegoComponent {
  constructor(private preguntasService: PreguntasService) {}

  questions: any[];
  numeroPregunta: number = 0;
  pregunta: any;
  respuestas: string[];
  selectedAnswer: string;
  resultado: boolean | null = null;  // Nueva variable para almacenar el resultado
  preguntasAcertadas: number = 0;
  preguntasFallidas: number = 0;

  ngOnInit() {
    this.preguntasService.getPreguntas().pipe(
      map((data: any) => data.results)
    ).subscribe((preguntas: any[]) => {
      this.questions = preguntas;
      this.pregunta = this.questions[this.numeroPregunta].question;
      this.respuestas = this.shuffleRespuestas(this.questions[this.numeroPregunta].incorrect_answers.concat(this.questions[this.numeroPregunta].correct_answer));
    });
  }

  getQuestion(): any {
    return this.pregunta;
  }

  getRespuestas(): string[] {
    return this.respuestas;
  }

  seleccionRespuesta(respuesta: string) {
    this.selectedAnswer = respuesta;
    this.resultado = this.verificarRespuesta(respuesta);

    // Incrementar el contador de preguntas acertadas o fallidas
    if (this.resultado) {
      this.preguntasAcertadas++;
    } else {
      this.preguntasFallidas++;
    }
  }

  verificarRespuesta(respuesta: string): boolean {
    return respuesta === this.questions[this.numeroPregunta].correct_answer;
  }

  obtenerSiguientePregunta() {
    this.numeroPregunta++;
    this.selectedAnswer = null;
    this.resultado = null;

    if (this.numeroPregunta < this.questions.length) {
      this.pregunta = this.questions[this.numeroPregunta].question;
      this.respuestas = this.shuffleRespuestas(this.questions[this.numeroPregunta].incorrect_answers.concat(this.questions[this.numeroPregunta].correct_answer));
    } else {
      // El juego ha terminado, puedes realizar alguna acción aquí
    }
  }

  shuffleRespuestas(respuestas: string[]): string[] {
    // Implementar lógica para mezclar respuestas (puedes usar un algoritmo de mezcla aleatoria)
    // Esto es solo un ejemplo básico
    return respuestas.sort(() => Math.random() - 0.5);
  }
}
