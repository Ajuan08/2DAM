import { Component } from '@angular/core';
import { QuestionsService } from 'src/services/questions-service/questions.service';

@Component({
  selector: 'game-page',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})
export class GameComponent {
  public question: any;
  public scoreboard: any;

  constructor(private questionsService: QuestionsService) {
    this.scoreboard = {
      preguntasAcertadas: 0,
      respuestaIncorrecta: 0
    }
  }

  ngOnInit() {
    this.getNewQuestion();
  }

  getNewQuestion() {
    this.questionsService.obtenerPreguntas().subscribe({
      next: (question) => {
        this.questionsService.obtenerPreguntas();
        this.question = question;
      },
      error: (error) => {
        console.error('Error obteniendo la pregunta: ', error);
      },
    });
  }

  checkAnswer(answer: any) {
    this.scoreboard = this.questionsService.checkAnswer(answer);
    this.getNewQuestion();
  }
}