import { Injectable } from '@angular/core';
import axios from 'axios';

@Injectable({
  providedIn: 'root'
})
export class LibroServiceService {
  apiUrl = 'http://192.168.12.51:8080/api/libros';
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

  createLibro(libro: any) {
    return axios.post(this.apiUrl, libro).then((response) => {
      return response.data;
    });
  }

  updateLibro(libro: any) {
    return axios.put(this.apiUrl + '/' + libro.id, libro).then((response) => {
      return response.data;
    });
  }

  deleteLibro(id: number) {
    return axios.delete(this.apiUrl + '/'+ id).then((response) => {
      return response.data;
    });
  }
}
