import { Injectable } from '@angular/core';
import { Joke } from './joke';

@Injectable({
  providedIn: 'root',
})
export class JokeService {
  private jokes: Joke[] = [
    new Joke("¿Cuál es el último animal que subió al arca de Noé?", "El del-fin"),
    new Joke("¿Cómo se dice pañuelo en japonés?", "Saka-moko"),
    new Joke("¿Cómo se dice pelo sucio en chino?", "Chin cham pu"),
  ];

  getJokes(): Joke[] {
    return this.jokes;
  }

  addJoke(joke: Joke) {
    this.jokes.unshift(joke);
  }

  deleteJoke(joke: Joke) {
    const index = this.jokes.indexOf(joke);
    if (index !== -1) {
      this.jokes.splice(index, 1);
    }
  }
}
