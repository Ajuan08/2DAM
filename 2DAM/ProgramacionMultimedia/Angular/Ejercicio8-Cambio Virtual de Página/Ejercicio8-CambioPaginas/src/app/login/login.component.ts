import { Component } from '@angular/core';
import { ServicioService } from '../servicio.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
username: any;
  constructor(private ServicioService: ServicioService, private router: Router) {}

  login(username: string): void {
    this.ServicioService.login(username);
    this.router.navigate(['/inicio']);
  }
}
