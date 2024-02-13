import { Component, EventEmitter, Injectable, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ServicioService } from '../servicio/servicio.service';

@Component({
  selector: 'app-formulario',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.scss'],
})



export class FormularioComponent  implements OnInit {

  @Output() addCurso = new EventEmitter<any>();

  cursoForm: FormGroup;

  alertButtons = ['Aceptar'];

  constructor() {
    this.cursoForm = new FormGroup({
      curso: new FormControl('', [Validators.required]),
      puntos: new FormControl('', [Validators.required])
    });
  }

  
  ngOnInit() {

  }

  anadir(){
    if (!this.cursoForm.invalid) {
      let objectCurso = {
        nombre: this.cursoForm.value.curso,
        puntos: this.cursoForm.value.puntos
      }
      this.addCurso.emit(objectCurso)
    }
  }

}
