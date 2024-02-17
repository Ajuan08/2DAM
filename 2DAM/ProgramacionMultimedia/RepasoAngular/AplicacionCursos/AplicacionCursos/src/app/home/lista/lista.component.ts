import { Component, Input, OnInit } from '@angular/core';
import { Datos, PersonaService } from '../../persona.service';

@Component({
  selector: 'app-lista',
  templateUrl: './lista.component.html',
  styleUrls: ['./lista.component.scss'],
})
export class ListaComponent  implements OnInit {

@Input() dato:any;

  constructor() {}

  ngOnInit() {}

}
