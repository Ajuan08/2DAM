import { Injectable } from '@angular/core';
import axios from 'axios';

@Injectable({
  providedIn: 'root'
})
export class CategoriaServiceService {
  apiUrl = 'http://192.168.12.51:8080/api/categorias';
  constructor() {}

  getCategorias() {
    return axios.get(this.apiUrl).then((response) => {
      return response.data;
    });
  }

  getCategoria(id: number) {
    return axios.get(this.apiUrl + '/'+ id).then((response) => {
      return response.data;
    });
  }

  createCategoria(categoria: any) {
    return axios.post(this.apiUrl, categoria).then((response) => {
      return response.data;
    });
  }

  updateCategoria(categoria: any) {
    return axios.put(this.apiUrl + '/'+ categoria.id, categoria).then((response) => {
      return response.data;
    });
  }

  deleteCategoria(id: number) {
    return axios.delete(this.apiUrl + '/'+ id).then((response) => {
      return response.data;
    });
  }
}
