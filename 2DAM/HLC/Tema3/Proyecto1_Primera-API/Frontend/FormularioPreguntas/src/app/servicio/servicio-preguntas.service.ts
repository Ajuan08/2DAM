import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ServicioPreguntasService {
  private apiUrl = 'http://localhost:3000/obtenerFrase';

  constructor(private http: HttpClient) {}

  obtenerFrase(): Observable<any> {
    return this.http.get(this.apiUrl);
  }
}
