import { Component } from '@angular/core';
import { Servicio } from '../servicio';

@Component({
  selector: 'app-principal',
  templateUrl: './principal.component.html',
  styleUrls: ['./principal.component.css']
})
export class PrincipalComponent {
  private servicio!: Servicio;
  libros!: any;
  libro!: any;

  constructor(){
    this.servicio = new Servicio();
    this.libros = this.servicio.getLibros();
  }

  obtenerLibro(id: Number){
    this.libro = this.servicio.getLibrosId(id);
  }

}
