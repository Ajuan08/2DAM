import { Injectable } from '@angular/core';
import { Usuario } from 'src/class/usuario';

@Injectable({
  providedIn: 'root'
})
export class UsuarioServicioService {

  private _usuarios: Usuario[];

  constructor() {
    this._usuarios = [
      new Usuario('Silvia', 'Guijo', 'silvia', '24022017'),
    ];
   }

  obtenerUsuario(usuario: string): Usuario {
    let user: Usuario | undefined = this._usuarios.find(user => user.usuario == usuario);

    if (user) {
      return new Usuario(user.nombre, user.apellido, user.usuario, user.contrasena);
    }
    
    return new Usuario('', '', '', '');
  }

  anadirUsuario(nombre: string, apellido: string, usuario: string, contrasena: string): boolean {
    if(this._usuarios.find(user => user.usuario == usuario)) {
      return false;
    }else{
      this._usuarios.push(new Usuario(nombre, apellido, usuario, contrasena));
      return true;
    }
  }
}
