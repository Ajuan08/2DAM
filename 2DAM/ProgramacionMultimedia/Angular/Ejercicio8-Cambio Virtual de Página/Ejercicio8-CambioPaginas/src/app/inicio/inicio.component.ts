import { Component } from '@angular/core';
import { ServicioService } from '../servicio.service';

@Component({
  selector: 'app-inicio',
  templateUrl: './inicio.component.html',
  styleUrls: ['./inicio.component.css']
})
export class InicioComponent {
  username: string;

  constructor(private ServicioService: ServicioService) {
    this.username = ServicioService.getUsername();
  }
}
