import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AutorServiceService } from '../services/autor-service.service';
import { Autor } from './Autor';

@Component({
  selector: 'app-autor-form',
  standalone: true,
  imports: [],
  templateUrl: './autor-form.component.html',
  styleUrl: './autor-form.component.css'
})
export class AutorFormComponent implements OnInit {
  nombre: string = '';
  autor!: Autor
  ListaAutores: Autor[] = [];

  constructor(private router:Router, private autorService: AutorServiceService ) {
}
  ngOnInit(): void {
    this.autor = new Autor(0, '');
    this.getAutores();
  }

  getAutores() {
    this.autorService.getAutores().then((response) => {
      console.log(response);
      this.ListaAutores = (response);
    });
  }

  guardarNuevo(autorNombre: any) {
    this.autor.nombre = autorNombre;
    this.autorService.createAutor(this.autor).then(() => {
      this.autor = new Autor(0, '');
      this.getAutores();
    });
  }

  editarAutor(autorNombre: any) {
    this.autor.id = this.autor.id;
    this.autor.nombre = autorNombre;
    this.autorService.updateAutor(this.autor).then((response) => {
      console.log(response);
      this.getAutores();
    });
  }

  eliminarAutor(id: number) {
    this.autorService.deleteAutor(id).then((response) => {
      console.log(response);
      this.getAutores();
    });
  }

  setAutor(id: number, nombre: string) {
    this.autor.id = id
    this.autor.nombre = nombre;
  }
}
