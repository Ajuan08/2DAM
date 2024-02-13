import { Component, isDevMode } from '@angular/core';
import { Router } from '@angular/router';
import { AutorServiceService } from '../services/autor-service.service';
import { CategoriaServiceService } from '../services/categoria-service.service';
import { Categoria } from './Categoria';

@Component({
  selector: 'app-categoria-form',
  standalone: true,
  imports: [],
  templateUrl: './categoria-form.component.html',
  styleUrl: './categoria-form.component.css'
})
export class CategoriaFormComponent {
  nombre: string = '';
  categoria!: Categoria
  ListaCategoria: any[] = [];

  constructor(private router:Router, private categoriaService: CategoriaServiceService ) {
}
  ngOnInit(): void {
    this.categoria = new Categoria(0, '');
    this.getCategorias();
  }

  getCategorias() {
    this.categoriaService.getCategorias().then((response) => {
      console.log(response);
      this.ListaCategoria = (response);
    });
  }

  guardarNuevo(autorNombre: any) {
    this.categoria.nombre = autorNombre;
    this.categoriaService.createCategoria(this.categoria).then(() => {
      this.categoria = new Categoria(0, '');
      this.getCategorias();
    });
  }

  editarCategoria(categoriaNombre: any) {
    this.categoria.id = this.categoria.id;
    this.categoria.nombre = categoriaNombre;
    this.categoriaService.updateCategoria(this.categoria).then((response) => {
      console.log(response);
      this.getCategorias();
    });
  }

  eliminarCategoria(id: number) {
    this.categoriaService.deleteCategoria(id).then((response) => {
      console.log(response);
      this.getCategorias();
    });
  }

  setCategoria(id: number, nombre: string){
    this.categoria.id = id;
    this.categoria.nombre = nombre;
  }
}
