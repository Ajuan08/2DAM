import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Libro } from './Libro';
import { LibroServiceService } from '../services/libro-service.service';
import { Autor } from '../autor-form/Autor';
import { Categoria } from '../categoria-form/Categoria';
import { CommonModule } from '@angular/common';
import { AutorServiceService } from '../services/autor-service.service';
import { CategoriaServiceService } from '../services/categoria-service.service';

@Component({
  selector: 'app-libro-form',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './libro-form.component.html',
  styleUrl: './libro-form.component.css'
})
export class LibroFormComponent implements OnInit{
  nombre: string = '';
  libro!: Libro;
  autores: Autor[] = [];
  categorias: Categoria[] = [];
  idAutor!: Autor;
  idCategoria: Categoria[] = [];
  ListaLibros: Libro[] = [];

  constructor(private router: Router, private libroServicio: LibroServiceService, private autorServicio: AutorServiceService, private categoriaService: CategoriaServiceService) {}
  ngOnInit(): void {
    this.libro = new Libro(0, '', this.idAutor, this.idCategoria);
    this.getLibros();
    this.getAutores();
    this.getCategorias();
  }

  getLibros() {
    this.libroServicio.getLibros().then((response) => {
      console.log(response);
      this.ListaLibros = (response);
    });
  }

  editarLibro(libro: Libro) {
    this.libro = libro;
  }

  eliminarLibro(id: number) {
    this.libroServicio.deleteLibro(id).then(() => {
      this.getLibros();
    });
  }

  guardarCambios() {
    this.libroServicio.createLibro(this.libro).then(() => {
      this.libro = new Libro(0, '', this.idAutor, this.idCategoria);
      this.getLibros();
    });
  }
  
  
  

  getAutores() {
    this.autorServicio.getAutores().then((response) => {
      console.log(response);
      this.autores = (response);
    });
  }

  getCategorias() {
    this.categoriaService.getCategorias().then((response) => {
      console.log(response);
      this.categorias = (response);
    });
  }

}
