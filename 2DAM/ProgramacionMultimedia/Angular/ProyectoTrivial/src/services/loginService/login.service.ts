import { Injectable } from '@angular/core';
import { UsuarioService } from '../usuarioService/usuario.service';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private usuarioService: UsuarioService) { }

  registrarse(usuario: string, contrasena: string): boolean {
    return this.usuarioService.anadirUsuario(usuario, contrasena);
  }

  login(usuario: string, contrasena: string): boolean {
    let user: any = this.usuarioService.obtenerUsuarios(usuario);

    if (user) {
      if (user.contrasena == contrasena) {
        return true;
      }
    }

    return false;
  }

  estaRegistrado(): boolean {
    return this.usuarioService.obtenerTodosUsuarios().length > 0;
  }
}
