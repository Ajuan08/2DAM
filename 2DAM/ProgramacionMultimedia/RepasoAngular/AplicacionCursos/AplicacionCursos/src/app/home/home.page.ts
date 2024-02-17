import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { PersonaService } from '../persona.service';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage implements OnInit{

  arrDatos: Observable<any[]>;

  constructor(private servicioPersona: PersonaService) 
  {
    this.arrDatos = this.servicioPersona.getDatos$();
  }

  ngOnInit() {}

  anadirCurso(dato: any): void
  {
    this.servicioPersona.agregarDatos(dato);
  }

}
