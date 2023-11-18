import { Component } from '@angular/core';
import { LibrosService } from '../libros.service';

@Component({
  selector: 'app-panel-lateral',
  templateUrl: './panel-lateral.component.html',
  styleUrls: ['./panel-lateral.component.css']
})
export class PanelLateralComponent {
  mostrarComponentes = false;

  constructor(private librosService: LibrosService) {}

  buscarLibros(filtrar: string) {
    this.librosService.obtenerLibrosFiltrados(filtrar);
  }
}
