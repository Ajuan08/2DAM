import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { PersonaService } from '../../persona.service';

@Component({
  selector: 'app-formulario',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.scss'],
})
export class FormularioComponent  implements OnInit {

  formulario: FormGroup;

  constructor(private personaService: PersonaService) {
    this.formulario = new FormGroup({
      nombre: new FormControl(),
      puntos: new FormControl()
    });
   }

  ngOnInit() {}

  onSubmit() {
    this.personaService.agregarDatos(this.formulario.value);
  }

}
