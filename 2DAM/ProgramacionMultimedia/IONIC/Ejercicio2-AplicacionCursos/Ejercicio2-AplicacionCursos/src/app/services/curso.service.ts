
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CursoService {
  private cursosSubject = new BehaviorSubject<string[]>([]);
  cursos$ = this.cursosSubject.asObservable();

  agregarCurso(curso: string): void {
    const cursos = this.cursosSubject.value;
    cursos.push(curso);
    this.cursosSubject.next(cursos);
  }

  obtenerCursos(): string[] {
    return this.cursosSubject.value;
  }
}

