import { Component, ViewChild } from '@angular/core';
import { Cabecera2Component } from './cabecera2/cabecera2.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Ejercicio1-Cabeceras';

  direccionImagen : string = '../assets/logo.png';

  @ViewChild(Cabecera2Component) cabecera2! : Cabecera2Component;

  ngAfterViewInit() {
    this.cabecera2.childImage.nativeElement.src = this.direccionImagen;
  }
}
