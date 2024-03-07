import { Injectable } from '@angular/core';
import { Usuario } from 'src/app/clases/usuario';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {
  private _usuarios: Usuario[];
  

  constructor() {
    this._usuarios = [
      new Usuario('ajuan', '24022017')
    ];
  }

  obtenerUsuario(nombre: string, contrasena: string): Object {
    let usuario = this._usuarios.find(usuario => usuario.nombre === nombre && usuario.contrasena === contrasena);
    if (usuario) {
      return {
        nombre: usuario.nombre,
        contrasena: usuario.contrasena
      };
    } else {
      return {};
    }
  }
}