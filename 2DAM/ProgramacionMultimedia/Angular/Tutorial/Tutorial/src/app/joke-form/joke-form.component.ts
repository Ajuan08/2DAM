import { Component, EventEmitter, Output } from '@angular/core';
import { JokeService } from '../joke.service';
import { Joke } from '../joke';

@Component({
  selector: 'joke-form',
  templateUrl: './joke-form.component.html',
  styleUrls: ['./joke-form.component.css']
})
export class JokeFormComponent {
  
  @Output() jokeCreated = new EventEmitter<Joke>();
  setup: string = '';
  punchline: string = '';

  constructor(private jokeService: JokeService) {}

  createJoke() {
    const newJoke = new Joke(this.setup, this.punchline);
    this.jokeService.addJoke(newJoke);
    this.jokeCreated.emit(newJoke);
    this.setup = '';
    this.punchline = '';
  }
}
