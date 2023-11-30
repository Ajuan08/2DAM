import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ServicioLoginService {

  private isLoggedIn = false;
  private usuario = '';

  login(usuario: string): void {
    this.isLoggedIn = true;
    this.usuario = usuario;
  }

  isLoggedInUser(): boolean {
    return this.isLoggedIn;
  }

  obtenerUsuario(): string {
    return this.usuario;
  }
}
