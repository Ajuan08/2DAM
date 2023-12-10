import { Injectable } from '@angular/core';
import { UsuarioServicioService } from './usuario-servicio.service';

@Injectable({
  providedIn: 'root'
})
export class LoginServicioService {

private estaLogeado: boolean = false;

  constructor(private usuarioServicio: UsuarioServicioService) { }

  registro(nombre: string, apellido: string, usuario: string, contrasena: string): boolean {
    return this.usuarioServicio.anadirUsuario(nombre, apellido, usuario, contrasena);

  }

  login(usuario: string, contrasena: string): boolean {
    let user = this.usuarioServicio.obtenerUsuario(usuario);
    if (user) {
     if(user.contrasena == contrasena && user.usuario == usuario) {
       this.estaLogeado = true;
       return true;
     }
  }
    return false;
  }

  estaLogeadoEnUsuario(): boolean {
    return this.estaLogeado;
  }
}
