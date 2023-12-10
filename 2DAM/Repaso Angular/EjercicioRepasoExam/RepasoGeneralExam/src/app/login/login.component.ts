import { Component } from '@angular/core';
import { LoginServicioService } from '../servicios/login-servicio.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  public error: boolean = false;
  public fraseError!: string;


  constructor(private loginService: LoginServicioService, private router: Router){}

  irRegistro(){
    this.router.navigate(['/registro']);
  }

  login(usuario: string, contrasena: string){
    if(usuario && contrasena){
      if(this.loginService.login(usuario, contrasena)){
        this.router.navigate(['/principal']);
      }else{
        this.error = true;
        this.fraseError = "Usuario y/o contraseña incorrectos";
      }
      
    }else{
      this.error = true;
      this.fraseError = "Usuario y/o contraseña incorrectos";
    }

  }
}
