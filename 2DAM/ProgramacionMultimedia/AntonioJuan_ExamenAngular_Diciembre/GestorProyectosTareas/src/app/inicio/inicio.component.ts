import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-inicio',
  templateUrl: './inicio.component.html',
  styleUrls: ['./inicio.component.css']
})
export class InicioComponent {

  titulo = 'Bienvenidos al gestor de proyectos y tareas';

  constructor(private route: Router) { }

  irProyectos() {
    this.route.navigate(['/proyectos']);
  }

}
