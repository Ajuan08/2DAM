import { Component} from '@angular/core';
import { Servicio } from 'src/app/clases/servicio/servicio';

@Component({
  selector: 'app-fondo',
  templateUrl: './fondo.component.html',
  styleUrls: ['./fondo.component.css']
})
export class FondoComponent {

  private servicio!: Servicio;
  libros!: any;
  libro!: any;

  constructor(){
    this.servicio = new Servicio();
    this.libros = this.servicio.getLibros();
  }

  obtenerLibro(id: Number){
    this.libro = this.servicio.getLibrosId(id);
  }

}
