import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoginServiceService {

  private autenticado: boolean = false;

  constructor() { }

  getAutenticado(){
    return this.autenticado;
  }

  login(nombre: string, password: string){
    if(nombre === "ajuan" && password === "1234"){
      this.autenticado = true;
    }else{
      this.autenticado = false;
    }
  }
}
