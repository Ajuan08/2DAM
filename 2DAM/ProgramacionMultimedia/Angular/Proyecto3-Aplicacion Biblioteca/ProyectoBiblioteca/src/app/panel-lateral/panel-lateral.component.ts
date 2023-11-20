import { Component } from '@angular/core';
import { LibrosService } from '../libros.service';

@Component({
  selector: 'app-panel-lateral',
  templateUrl: './panel-lateral.component.html',
  styleUrls: ['./panel-lateral.component.css']
})
export class PanelLateralComponent {
  mostrarComponentes = false;
  librosFiltrados!: Object[];

  constructor(private librosService: LibrosService) {}

  buscarLibros(filtrar: string) {
    this.librosService.obtenerLibrosFiltrados(filtrar).subscribe(
      libros => {
        this.librosFiltrados = libros;
      },
      error => {
        console.error('Error al obtener libros filtrados', error);
      }
    );
  }
}
