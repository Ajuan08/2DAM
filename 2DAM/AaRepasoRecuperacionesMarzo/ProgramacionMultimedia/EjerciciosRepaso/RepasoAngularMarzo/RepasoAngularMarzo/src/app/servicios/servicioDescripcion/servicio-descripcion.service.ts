import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ServicioDescripcionService {

  private descripcion$: BehaviorSubject<string> = new BehaviorSubject('')

  constructor() { }

  enviarDescripcion(descripcion: string) {
    let descrip = descripcion
    this.descripcion$.next(descrip)
  }

  getDescripcion$(): Observable<string> {
    return this.descripcion$.asObservable()
  }
}
