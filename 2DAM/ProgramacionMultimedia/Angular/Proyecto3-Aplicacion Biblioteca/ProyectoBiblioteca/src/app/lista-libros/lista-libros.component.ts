import { Component, OnInit } from '@angular/core';
import { LibrosService } from '../libros.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-lista-libros',
  templateUrl: './lista-libros.component.html',
  styleUrls: ['./lista-libros.component.css']
})
export class ListaLibrosComponent implements OnInit {
  mostrarComponentes = false;
  libros: any = [];
  observable: Observable<any[]>;

  constructor(private librosService: LibrosService) {
    this.observable = this.librosService.subject;
  }

  ngOnInit() {
    this.librosService.subject.subscribe(
      libros => {
        this.libros = libros;
      },
      error => {
        console.error('Error al obtener libros', error);
      }
    );
  }

  login() {
    this.mostrarComponentes = true;
  }
}
