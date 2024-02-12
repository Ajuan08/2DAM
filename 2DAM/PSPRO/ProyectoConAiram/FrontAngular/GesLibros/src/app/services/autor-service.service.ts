import { Injectable } from '@angular/core';
import axios from 'axios';
import { Autor } from '../autor-form/Autor';

@Injectable({
  providedIn: 'root'
})
export class AutorServiceService {
  apiUrl = 'http://localhost:8080/api/autores';
  constructor() {}

  getAutores() {
    return axios.get(this.apiUrl).then((response) => {
      return response.data;
    });
  }

  getAutor(id: number) {
    return axios.get(this.apiUrl + '/' + id).then((response) => {
      return response.data;
    });
  }

  createAutor(autor: Autor) {
    return axios.post(this.apiUrl, autor).then((response) => {
      return response.data;
    });
  }

  updateAutor(autor: Autor) {
    return axios.put(this.apiUrl + '/' + autor.id, autor).then((response) => {
      return response.data;
    });
  }

  deleteAutor(id: number) {
    return axios.delete(this.apiUrl + '/' + id).then((response) => {
      return response.data;
    });
  }

}
