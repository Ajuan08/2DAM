import { Component } from '@angular/core';
import { ProyectoServicioService } from '../servicio/proyecto-servicio.service';
import { Proyecto } from '../clase/proyecto';

@Component({
  selector: 'app-proyectos',
  templateUrl: './proyectos.component.html',
  styleUrls: ['./proyectos.component.css']
})
export class ProyectosComponent {

  titulo = 'Proyectos';
  constructor(private proyectosService: ProyectoServicioService) 
  {
    
   }

  obtenerProyectos(){
  }

  mostrarDetalles(nombre: string, descripcion: string, fechaCreacion: Date){

    return this.proyectosService.mostrarDetalles(nombre, descripcion, fechaCreacion);
  } 

}
