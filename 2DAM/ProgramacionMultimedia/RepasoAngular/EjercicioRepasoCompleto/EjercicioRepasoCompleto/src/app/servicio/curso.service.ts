import { Injectable } from '@angular/core';
import { Curso } from '../classes/curso';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CursoService {

  private listaCursos: Curso[] = [];
  private listaCursos$: BehaviorSubject<Curso[]> = new BehaviorSubject<Curso[]>([]);


  constructor() {
    this.listaCursos = [
      new Curso('Angular', 100),
      new Curso('Ionic', 200),
      new Curso('React', 300)
    ];
    this.listaCursos$.next(this.listaCursos);
   }

   anadirCurso(nombre: string, puntos: number){
    this.listaCursos.push(new Curso(nombre, puntos));
    this.listaCursos$.next(this.listaCursos);
    
   }

   getListaCursos$(): Observable<Curso[]>{
     return this.listaCursos$.asObservable();
   }

   getListaCursos(){
    return [...this.listaCursos]
  }
}
