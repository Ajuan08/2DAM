import { Component, OnInit } from '@angular/core';
import { ServicioService } from '../servicio/servicio.service';


@Component({
  selector: 'app-principal',
  templateUrl: './principal.page.html',
  styleUrls: ['./principal.page.scss'],
})
export class PrincipalPage implements OnInit {

  cursos: any;

  constructor(private servicio: ServicioService) { }

  ngOnInit() {
    this.servicio.obtenerCursos().subscribe(cursos => {
      this.cursos = cursos;
    });
  }

  addCurso(objectCurso: any){
    this.servicio.anadirCurso(objectCurso.nombre, objectCurso.puntos)
  }

}
