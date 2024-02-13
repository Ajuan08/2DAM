import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Libro } from './Libro';
import { LibroServiceService } from '../services/libro-service.service';
import { Autor } from '../autor-form/Autor';
import { Categoria } from '../categoria-form/Categoria';
import { CommonModule } from '@angular/common';
import { CategoriaServiceService } from '../services/categoria-service.service';
import { AutorServiceService } from '../services/autor-service.service';
import { FormsModule, ReactiveFormsModule, FormGroup, FormBuilder, FormArray } from '@angular/forms';

@Component({
  selector: 'app-libro-form',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './libro-form.component.html',
  styleUrl: './libro-form.component.css'
})
export class LibroFormComponent implements OnInit{
  nombre!: string;
  libro!: Libro;
  autores: Autor[] = [];
  categorias: Categoria[] = [];
  idAutor!: Autor;
  ListaLibros: Libro[] = [];
  selectedCategorias: number[] = [];

  constructor(private router: Router, 
    private libroServicio: LibroServiceService, 
    private categoryService: CategoriaServiceService, 
    private autoService: AutorServiceService) {
  }
  ngOnInit(): void {
    this.libro = new Libro('', this.idAutor, this.categorias);
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
    this.libro = libro
  }

  eliminarLibro(id: number) {
    this.libroServicio.deleteLibro(id).then(() => {
      this.getLibros();
    });
  }

  guardarNuevo(nombre: string) {
    this.setLibro(nombre)
    //this.libro = new Libro(nombre, this.libro.autor, this.libro.categorias)
    console.log(this.libro);
    this.libroServicio.createLibro(this.libro).then(() => {
      this.getLibros();
    });
  }

  guardarCambios(nombre: string) {
    this.setLibro(nombre)
    this.libroServicio.updateLibro(this.libro).then(() => {
      this.getLibros();
    });
  }

  getAutores() {
    this.autoService.getAutores().then((response) => {
      console.log(response);
      this.autores = (response);
    });
  }

  getCategorias() {
    this.categoryService.getCategorias().then((response) => {
      console.log(response);
      this.categorias = (response);
    });
  }

  setLibro(nombre: string) {
    this.libro.titulo = nombre
    this.libro.autor = this.idAutor
    this.categorias.forEach((categoria, index) => {
      if (this.selectedCategorias.includes(index)) {
        this.libro.categorias.push(categoria);
      }
    });
  }

  onCategoriaChange(event: Event) {
    const isChecked = (event.target as HTMLInputElement).checked;
    const index = parseInt((event.target as HTMLInputElement).name.split('_')[1]);
  
    if (isChecked) {
      this.selectedCategorias.push(index);
    } else {
      const i = this.selectedCategorias.indexOf(index);
      this.selectedCategorias.splice(i, 1);
    }
  }

  onAutorChange(event: Event) {
    const index = (event.target as HTMLSelectElement).selectedIndex;
    console.log(index);
    this.idAutor = this.autores[index];
    console.log(this.idAutor);
  }

}
