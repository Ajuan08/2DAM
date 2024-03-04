import { Injectable } from '@angular/core';
import { Usuario } from 'src/Clases/Usuario';


@Injectable({
  providedIn: 'root'
})
export class UsuarioService {
  private _users: Usuario[];

  constructor() { 
    this._users = [];
  }

  obtenerUsuarios(usuario: string): Object {
    let user: Usuario | undefined = this._users.find(user => user.usuario == usuario);

    if (user) {
      return {
        usuario: user.usuario,
        contrasena: user.contrasena
      }
    }
    
    return {}
  }

  anadirUsuario(usuario: string, contrasena: string): boolean {
    if (this._users.find(user => user.usuario == usuario)) {
      return false;
    } else {
      this._users.push(new Usuario(usuario, contrasena));
      return true;
    }
  }

  obtenerTodosUsuarios(): Usuario[] {
    return this._users;
  }
}
