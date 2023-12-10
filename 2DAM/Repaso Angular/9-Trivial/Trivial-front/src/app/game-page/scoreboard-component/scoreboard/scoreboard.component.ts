import { Component, Input } from '@angular/core';

@Component({
  selector: 'scoreboardPanel',
  templateUrl: './scoreboard.component.html',
  styleUrls: ['./scoreboard.component.css']
})
export class ScoreboardComponent {
  @Input() preguntasAcertadasCount: Number = 0;
  @Input() respuestaIncorrectaCount: Number = 0;

  constructor() {}
}
