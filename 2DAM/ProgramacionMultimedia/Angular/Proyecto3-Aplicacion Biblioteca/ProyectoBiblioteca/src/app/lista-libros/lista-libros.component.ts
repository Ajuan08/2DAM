import { Component } from '@angular/core';
import { LibrosService } from '../libros.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-lista-libros',
  templateUrl: './lista-libros.component.html',
  styleUrls: ['./lista-libros.component.css']
})
export class ListaLibrosComponent {
  mostrarComponentes = false;
  libros:any = [];
  observable: Observable<any[]>;

  constructor(private librosService: LibrosService){
    this.libros = this.librosService.libros;
    this.observable = this.librosService.subject;
  }

  login(){
    this.mostrarComponentes = true;
  }
}
