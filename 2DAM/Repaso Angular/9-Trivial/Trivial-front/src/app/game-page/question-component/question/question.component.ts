import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'questionPanel',
  templateUrl: './question.component.html',
  styleUrls: ['./question.component.css']
})
export class QuestionComponent {
  @Input() question: any;
  @Output() checkAnswerEvent = new EventEmitter<string>();
  public tituloPregunta: string | undefined;
  public answers: string[] | undefined;

  constructor() {}

  ngOnChanges() {
    if (this.question) {
      this.tituloPregunta = this.question.tituloPregunta;
      this.answers = this.question.answers;
    }
  }

  checkAnswer(answer: string) {
    this.checkAnswerEvent.emit(answer);
  }
}
