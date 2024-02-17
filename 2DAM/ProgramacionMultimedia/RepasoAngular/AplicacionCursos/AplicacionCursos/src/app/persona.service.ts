import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';


export interface Datos {
  id: string;
  nombre: string;
  puntos: number;
}

@Injectable({
  providedIn: 'root'
})
export class PersonaService {

  private datos: Datos[];
  private datos$: BehaviorSubject<Datos[]>;

  constructor() {
    this.datos = [];
    this.datos$ = new BehaviorSubject(this.datos);
   }

   agregarDatos(dDatos: Datos) {
     this.datos.push(dDatos);
     this.datos$.next(this.datos);
   }

   eliminarDatos(index: number) {
     this.datos.splice(index, 1);
     this.datos$.next(this.datos);
   }

   getDatos$(): Observable<Datos[]> {
     return this.datos$.asObservable();
   }

   getCurso(id: string) {
    let datos = this.datos.find(datos => datos.id === id);

    if (datos) {
      return {
        id: datos.id,
        nombre: datos.nombre,
        puntos: datos.puntos
      };
    }
    return null;
  }
}
