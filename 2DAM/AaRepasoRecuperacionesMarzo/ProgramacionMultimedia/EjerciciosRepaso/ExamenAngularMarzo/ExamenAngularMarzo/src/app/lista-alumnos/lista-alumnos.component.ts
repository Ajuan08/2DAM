import { Component } from '@angular/core';
import { Alumnos } from '../class/alumnos';

@Component({
  selector: 'app-lista-alumnos',
  templateUrl: './lista-alumnos.component.html',
  styleUrls: ['./lista-alumnos.component.css']
})
export class ListaAlumnosComponent {

  

  public listaAlumnos: Alumnos[] = [
    new Alumnos("Antonio Juan", "DAM", this.notaMedia(5,5,5), 5,5,5),
    new Alumnos("Joaquin", "DAM", this.notaMedia(5,5,5), 5,5,5),
    new Alumnos("David", "DAW", this.notaMedia(5,5,5), 5,5,5),
  ];

  public getListaAlumnos(): Alumnos[] {
    return this.listaAlumnos;
  }

public notaMedia(nota1: number, nota2: number, nota3: number): number {
  return (nota1 + nota2 + nota3) / 3;

}
}
