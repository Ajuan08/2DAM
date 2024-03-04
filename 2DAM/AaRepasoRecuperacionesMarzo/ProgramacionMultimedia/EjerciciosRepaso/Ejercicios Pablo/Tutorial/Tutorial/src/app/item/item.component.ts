import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Joke } from '../joke';
import { JokeService } from '../joke.service';

@Component({
  selector: 'item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css']
})
export class ItemComponent {

  @Input('joke') data!: Joke;
  @Output() jokeDeleted = new EventEmitter<Joke>();

  constructor(private jokeService: JokeService) {}

  deleteJoke() {
    this.jokeService.deleteJoke(this.data);
    this.jokeDeleted.emit(this.data);
  }
}
