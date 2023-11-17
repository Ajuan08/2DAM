import { Component } from '@angular/core';
import { LibrosService } from '../libros.service';

@Component({
  selector: 'app-lista-libros',
  templateUrl: './lista-libros.component.html',
  styleUrls: ['./lista-libros.component.css']
})
export class ListaLibrosComponent {
  mostrarComponentes = false;
  libros:any = [];

  constructor(private librosService: LibrosService){
    this.libros = this.librosService.getLibros();
  }

  login(){
    this.mostrarComponentes = true;
  }
}
