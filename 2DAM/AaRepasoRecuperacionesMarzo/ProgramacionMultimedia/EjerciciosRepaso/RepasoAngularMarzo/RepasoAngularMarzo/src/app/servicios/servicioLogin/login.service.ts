import { Injectable } from '@angular/core';
import { UsuarioService } from '../servicioUsuarios/usuario.service';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  private _usuarioLogueado: boolean = false;
  constructor(private usuarioService: UsuarioService) { }

  login(nombre: string, contrasena: string): boolean {
    let usuario: any = this.usuarioService.obtenerUsuario(nombre, contrasena);

    if (usuario) {
      if(usuario.nombre === nombre && usuario.contrasena === contrasena){
        this._usuarioLogueado = true;
        return true;

      }
    }
    this._usuarioLogueado = false;
    return false;
  }

  estaLogueado(): boolean {
    return this._usuarioLogueado;
  }
}
