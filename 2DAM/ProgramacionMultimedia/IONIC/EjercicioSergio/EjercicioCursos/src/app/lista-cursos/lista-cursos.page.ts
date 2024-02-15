import { Component } from '@angular/core';

@Component({
  selector: 'app-lista-cursos',
  templateUrl: './lista-cursos.page.html',
  styleUrls: ['./lista-cursos.page.scss'],
})
export class ListaCursosPage {
  listaCursos: { id: number, curso: string, puntos: string }[] = [];
  nextId = 1;
  curso:string = '';
  puntos:string = '';
  constructor() {}

  agregarCurso() {
    // Agregar un nuevo curso con un id único
    this.listaCursos.push({ id: this.nextId++, curso: this.curso, puntos: this.puntos });
    this.curso = '';
    this.puntos = '';
  }

  


}
