import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Libro } from './model/libro';

@Injectable({
  providedIn: 'root'
})
export class LibrosService {

  private _libros: Libro[];
  private _subject: BehaviorSubject<Object[]>;

  constructor() {
   
    this._libros = [];

    this._libros.push(new Libro("Geronimo Stilton", "Airam", "3456789033", new Date(2020, 8, 12)));
    this._libros.push(new Libro("Angular", "Juan", "8765432113", new Date(2017, 2, 24)));

    this._subject = new BehaviorSubject<Object[]>(this._libros);
  }

  public get subject(): Observable<Object[]> {
    return this._subject.asObservable();
  }

  public get libros(): Object[]{
    return this.getLibros(this._libros);
  }

  public obtenerLibrosFiltrados(filtrar: string): Observable<Object[]> {
    let librosFiltrados: Libro[] = this._libros.filter(libro => libro.titulo.includes(filtrar));
    this._subject.next(this.getLibros(librosFiltrados));
    return this.subject; 
  }
  
  

  public getLibros(libros: Libro[]): Object[] {
    let lib : Object[] = [];

    libros.forEach(libro => {
      lib.push({
        titulo: libro.titulo,
        autor: libro.autor,
        ISBN: libro.ISBN,
        fecha_prestamo: libro.fecha_prestamo
      })
    });
    return lib;
  }
}
