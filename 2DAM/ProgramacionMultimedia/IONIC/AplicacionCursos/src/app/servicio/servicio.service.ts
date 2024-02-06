import { Injectable } from '@angular/core';
import { Curso } from '../Clases/curso';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ServicioService {

  private cursos!: Curso[];
  
  private cursosSubject: BehaviorSubject<Curso[]> = new BehaviorSubject<Curso[]>([]);

  constructor() {
    this.cursos = [];
  }

  anadirCurso(nombre: string, puntos: number){
    this.cursos.push(new Curso(nombre, puntos));
    this.cursosSubject.next([...this.cursos]);
  }
  
  obtenerCursos(): Observable<Curso[]> {
    return this.cursosSubject.asObservable();
  }

  buscarCursoId(id: number){
    const curso = this.cursos.find(element => element.getId() == id);
    if(curso){
      const objetoCurso = {
        id: curso.getId(),
        nombre: curso.getNombreCurso(),
        puntos: curso.getPuntos()
      };
      return objetoCurso
    }
    return null;
  }

  eliminarCurso(id: number){
    this.cursos = this.cursos.filter(curso => curso.getId() != id);
    this.cursosSubject.next([...this.cursos]);
  }
  

}
