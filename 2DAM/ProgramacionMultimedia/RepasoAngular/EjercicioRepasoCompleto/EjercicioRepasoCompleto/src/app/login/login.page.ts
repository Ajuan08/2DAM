import { Component, OnInit, inject } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginServiceService } from '../servicio/login-service.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {

  loginForm!:FormGroup;

  alertButtons = ["Aceptar"];

  router = inject(Router);

  constructor(private loginService: LoginServiceService) { }

  ngOnInit() {
    this.loginForm = new FormGroup({
      nombre: new FormControl('', [Validators.required]),
      password: new FormControl('', [Validators.required])
    });
  }

  iniciarSesion(){
    if(this.loginForm.valid){
      this.loginService.login(this.loginForm.value.nombre, this.loginForm.value.password);
      this.router.navigate(['/home']);
    }else{
      console.log("Formulario inválido");
    }
  }

}
