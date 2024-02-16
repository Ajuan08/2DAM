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
  selectedCategorias: Categoria[] = [];

  constructor(private router: Router, 
    private libroServicio: LibroServiceService, 
    private categoryService: CategoriaServiceService, 
    private autoService: AutorServiceService) {
  }
  
  ngOnInit() {
    this.getLibros();
    this.getAutores();
    this.getCategorias();
    this.libro = new Libro('', new Autor(0,""), this.categorias);
    console.log(this.libro);
  }

  getLibros() {
    this.libroServicio.getLibros().then((response) => {
      console.log(response);
      this.ListaLibros = (response);
    });
  }

  editarLibro(libro: Libro) {
    this.selectedCategorias = [];
    this.idAutor = libro.autor;
    libro.categorias.forEach((categoria, index) => {
      console.log(categoria);
      this.selectedCategorias.push(categoria);
    });
    this.libro = libro
    console.log(this.selectedCategorias);
  }

  eliminarLibro(id: number) {
    this.libroServicio.deleteLibro(id).then(() => {
      this.getLibros();
    });
  }

  isSelected(categoriaA: Categoria): boolean {
    this.selectedCategorias.forEach(categoria => {
      return categoriaA.id == categoria.id;
    });
    return false;
    //return this.selectedCategorias.includes(categoria);
  }

  guardarNuevo(nombre: string) {
    this.setLibro(nombre)
    console.log(this.libro);
    if (this.libro.categorias.length == 0) {
      alert('Debe seleccionar al menos una categoria');
    }else{
      this.libroServicio.createLibro(this.libro).then(() => {
        this.getLibros();
        this.libro = new Libro('', new Autor(0,""), this.categorias);
        this.selectedCategorias = [];
      });
    }
    
  }

  guardarCambios(nombre: string) {
    this.setLibro(nombre)
    if (this.libro.categorias.length == 0) {
      alert('Debe seleccionar al menos una categoria');
    }else{
      this.libroServicio.updateLibro(this.libro).then(() => {
        this.getLibros();
        this.libro = new Libro('', new Autor(0,""), this.categorias);
        this.selectedCategorias = [];
      });
    }
  }

  getAutores() {
    this.autoService.getAutores().then((response) => {
      console.log(response);
      this.autores = (response);
      this.idAutor = this.autores[0];
    });
  }

  getCategorias() {
    this.categoryService.getCategorias().then((response) => {
      console.log(response);
      this.categorias = (response);
      
    });
  }

  setLibro(nombre: string) {
    this.libro.categorias = [];
    this.libro.titulo = nombre
    if (this.idAutor == null) {
      this.idAutor = this.autores[0];
    }
    this.libro.autor = this.idAutor
    this.categorias.forEach((categoria, index) => {
      if (this.selectedCategorias.includes(categoria)) {
        this.libro.categorias.push(categoria);
      }
    });
  }

  onCategoriaChange(event: Event) {
    const isChecked = (event.target as HTMLInputElement).checked;
    const index = parseInt((event.target as HTMLInputElement).name.split('_')[1]);
  
    if (isChecked) {
      this.selectedCategorias.push(this.categorias[index]);
    } else {
      const i = this.selectedCategorias.indexOf(this.categorias[index]);
      this.selectedCategorias.splice(i, 1);
    }
  }

  onAutorChange(event: Event) {
    const index = (event.target as HTMLSelectElement).selectedIndex;
    console.log(index);
    this.idAutor = this.autores[index-1];
    console.log(this.idAutor);
  }

}
