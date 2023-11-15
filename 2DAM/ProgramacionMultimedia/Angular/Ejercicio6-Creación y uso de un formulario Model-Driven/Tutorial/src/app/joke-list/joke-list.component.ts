import { Component } from '@angular/core';
import { Joke } from '../joke';
import { JokeService } from '../joke.service';

@Component({
  selector: 'joke-list',
  templateUrl: './joke-list.component.html',
  styleUrls: ['./joke-list.component.css']
})
export class JokeListComponent {

  jokes: Joke[];

  constructor(private jokeService: JokeService) {
    this.jokes = this.jokeService.getJokes();
  }

  addJoke(joke: Joke) {
    this.jokeService.addJoke(joke);
  }

  deleteJoke(joke: Joke) {
    this.jokeService.deleteJoke(joke);
  }
}
