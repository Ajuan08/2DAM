import { Component, EventEmitter, Output } from '@angular/core';
import { JokeService } from '../joke.service';
import { Joke } from '../joke';
import {FormBuilder, FormControl, FormGroup, Validators} from '@angular/forms';

@Component({
  selector: 'joke-form',
  templateUrl: './joke-form.component.html',
  styleUrls: ['./joke-form.component.css']
})
export class JokeFormComponent {
  @Output() jokeCreated = new EventEmitter<any>();
  formulario!: FormGroup

  createJoke(setup:string, punchline:string) {
    this.jokeCreated.emit({setup:setup, punchline:punchline});
  }
  constructor(private formBuilder: FormBuilder) {
    this.formulario = this.formBuilder.group({
      pregunta: ['', [Validators.required, Validators.minLength(6)]],
      respuesta : ['', [Validators.required, Validators.minLength(6)]]
    })

    
  }
}
