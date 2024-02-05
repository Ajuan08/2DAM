import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-libro-form',
  standalone: true,
  imports: [],
  templateUrl: './libro-form.component.html',
  styleUrl: './libro-form.component.css'
})
export class LibroFormComponent {
  nombre: string = '';
  idAutor: number = 1;
  idCategoria: number = 1;

  constructor(private router: Router) {}

  guardarLibro() {
    console.log('Libro guardado:', this.nombre, 'Autor:', this.idAutor, 'Categoría:', this.idCategoria);
    this.router.navigate(['/']);
  }
}
