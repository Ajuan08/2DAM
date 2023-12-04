import { Injectable } from '@angular/core';
import { Usuario } from '../Clases/usuario';

@Injectable({
  providedIn: 'root'
})
export class UsuariosService {

  private _usuario: Usuario[];

  constructor() { 
    this._usuario = [];
  }

  obtenerUsuario(usuario: string): Object {
    let usu: Usuario | undefined = this._usuario.find(usu => usu.usuario == usuario);

    if (usu) {
      return {
        usuario: usu.usuario,
        contrasena: usu.contrasena
      }
    }
    
    return {}
  }

  anadirUsuario(usuario: string, contrasena: string): boolean {
    if (this._usuario.find(usu => usu.usuario == usuario)) {
      return false;
    } else {
      this._usuario.push(new Usuario(usuario, contrasena));
      return true;
    }
  }
}
