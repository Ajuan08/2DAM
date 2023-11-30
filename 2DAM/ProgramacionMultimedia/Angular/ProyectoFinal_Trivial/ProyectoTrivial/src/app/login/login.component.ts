import { Component } from '@angular/core';
import { ServicioLoginService } from '../Servicios/servicio-login.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
 usuario : any;
  constructor(private ServicioLoginService: ServicioLoginService, private router: Router){}

  login(usuario: string):void {
    this.ServicioLoginService.login(usuario);
    this.router.navigate(['/preguntas']);
  }

  
}
