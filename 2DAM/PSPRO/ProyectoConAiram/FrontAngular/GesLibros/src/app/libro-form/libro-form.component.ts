import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Libro } from './Libro';
import { LibroServiceService } from '../services/libro-service.service';
import { Autor } from '../autor-form/Autor';
import { Categoria } from '../categoria-form/Categoria';

@Component({
  selector: 'app-libro-form',
  standalone: true,
  imports: [],
  templateUrl: './libro-form.component.html',
  styleUrl: './libro-form.component.css'
})
export class LibroFormComponent implements OnInit{
  nombre: string = '';
  libro!: Libro
  idAutor!: Autor;
  idCategoria: Categoria[] = [];
  ListaLibros: Libro[] = [];

  constructor(private router: Router, private libroServicio: LibroServiceService) {}
  ngOnInit(): void {
    this.libro = new Libro(0, '', this.idAutor, this.idCategoria);
    this.getLibros();
  }

  getLibros() {
    this.libroServicio.getLibros().then((response) => {
      console.log(response);
      this.ListaLibros = (response);
    });
  }
}
