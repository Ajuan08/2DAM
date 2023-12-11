import { Injectable } from '@angular/core';
import { Proyecto } from '../clase/proyecto';

@Injectable({
  providedIn: 'root'
})
export class ProyectoServicioService {

  private _proyectos: Proyecto[];


  constructor() {
    this._proyectos = [
      new Proyecto('Proyecto 1', 'Descripción del proyecto 1', new Date()),
      new Proyecto('Proyecto 2', 'Descripción del proyecto 2', new Date()),
      new Proyecto('Proyecto 3', 'Descripción del proyecto 3', new Date()),
      new Proyecto('Proyecto 4', 'Descripción del proyecto 4', new Date()),
      new Proyecto('Proyecto 5', 'Descripción del proyecto 5', new Date())
      
    ];
   }

   obtenerProyectos(nombre: string, descripcion: string, fechaCreacion: Date){
      return this._proyectos;
   }

   mostrarDetalles(nombre: string, descripcion: string, fechaCreacion: Date){

    if(nombre != '' && descripcion != '' && fechaCreacion != null){
      return true;


   }else{ 
      return false;
    }

  }
}
