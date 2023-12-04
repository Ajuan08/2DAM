import { Injectable } from '@angular/core';
import { UsuariosService } from './usuarios.service';

@Injectable({
  providedIn: 'root'
})
export class ServicioLogin {

  constructor(private UsuariosService : UsuariosService) { }

  registro(usuario: string, contrasena: string): boolean {
    return this.UsuariosService.anadirUsuario(usuario, contrasena);
  }

  login(usuario: string, contrasena: string): boolean {
    let usu: any = this.UsuariosService.obtenerUsuario(usuario);

    if (usu) {
      if (usu.contrasena == contrasena) {
        return true;
      }
    }

    return false;
  }
}
