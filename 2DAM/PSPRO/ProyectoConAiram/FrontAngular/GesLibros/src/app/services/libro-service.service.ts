import { Injectable } from '@angular/core';
import axios from 'axios';
import { Libro } from '../libro-form/Libro';

@Injectable({
  providedIn: 'root'
})
export class LibroServiceService {
  apiUrl = 'http://localhost:8080/api/libros';
   constructor() { }
  
  getLibros() {
    return axios.get(this.apiUrl).then((response) => {
      return response.data;
    });
  }

  getLibro(id: number) {
    return axios.get(this.apiUrl + '/'+ id).then((response) => {
      return response.data;
    });
  }

  createLibro(libro: Libro) {
    let libroliteral = {
      titulo: libro.titulo,
      autor: libro.autor,
      categorias: libro.categorias
    }
    console.log(libroliteral);
    return axios.post(this.apiUrl, libroliteral).then((response) => {
      return response.data;
    });
  }

  updateLibro(libro: Libro) {
    return axios.put(this.apiUrl + '/' + libro.id, libro).then((response) => {
      return response.data;
    });
  }

  deleteLibro(id: number) {
    return axios.delete(this.apiUrl + '/'+ id).then((response) => {
      return response.data;
    });
  }

  getAutores() {
    return axios.get(`${this.apiUrl}/autores`).then((response) => {
      return response.data;
    });
  }

  getCategorias() {
    return axios.get(`${this.apiUrl}/categorias`).then((response) => {
      return response.data;
    });
  }
}
