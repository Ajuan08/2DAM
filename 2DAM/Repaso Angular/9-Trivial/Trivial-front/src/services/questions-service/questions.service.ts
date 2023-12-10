import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class QuestionsService {
  private apiUrl: string;
  private preguntaActual: any;
  private scoreboard: any;

  constructor(private http: HttpClient) { 
    this.apiUrl = 'http://localhost:3000/obtenerPreguntas';

    this.scoreboard = {
      preguntasAcertadas: 0,
      respuestaIncorrecta: 0
    }
  }

  public obtenerPreguntas(): Observable<any> {
    return this.http.get<any>(this.apiUrl).pipe(
      map((response) => {
        this.preguntaActual = response;

        return {
          tituloPregunta: response.tituloPregunta,
          answers: [response.respuestCorrecta, ...response.respuestaIncorrecta].sort(() => Math.random() - 0.5),
        };
      })
    );
  }

  public checkAnswer(answer: string): Object {
    if (answer === this.preguntaActual.respuestCorrecta) {
      this.scoreboard.preguntasAcertadas++;
    } else {
      this.scoreboard.respuestaIncorrecta++;
    }

    return this.scoreboard;
  }
}
