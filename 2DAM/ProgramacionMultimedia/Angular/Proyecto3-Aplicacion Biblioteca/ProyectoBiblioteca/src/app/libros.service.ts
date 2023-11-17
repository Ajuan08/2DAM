import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LibrosService {

  private libros = [
    {
      titulo: 'Geronimo Stilton',
      autor: 'Airam',
      ISBN: '3456789033',
      fecha_prestamo: '10/10/2022', 
    },
    {
      titulo: 'Angular',
      autor: 'Juan',
      ISBN: '8765432113',
      fecha_prestamo: '24/02/2017', 
    },
    
  ];

  constructor() {}

  getLibros() {
    return this.libros;
  }

  buscarLibros(termino: string) {
    return this.libros.filter(libro =>
      libro.titulo.toLowerCase().includes(termino.toLowerCase())
    );
  }
}
