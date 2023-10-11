import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Joke } from '../joke';

@Component({
  selector: 'item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.css']
})
export class ItemComponent {

  @Input('joke') data!: Joke;

  @Output() jokeDeleted = new EventEmitter<Joke>();

  deleteJoke() {
    this.jokeDeleted.emit(this.data);
  }
}
