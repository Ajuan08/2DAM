import { Component, EventEmitter, Output } from '@angular/core';
import { JokeService } from '../joke.service';
import { Joke } from '../joke';

@Component({
  selector: 'joke-form',
  templateUrl: './joke-form.component.html',
  styleUrls: ['./joke-form.component.css']
})
export class JokeFormComponent {
  @Output() jokeCreated = new EventEmitter<any>();

  createJoke(setup:string, punchline:string) {
    this.jokeCreated.emit({setup:setup, punchline:punchline});
  }
}
