import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-detalles-curso',
  templateUrl: './detalles-curso.page.html',
  styleUrls: ['./detalles-curso.page.scss'],
})
export class DetallesCursoPage implements OnInit {
  id: string = '';
  curso: string = '';
  puntos: string = '';

  constructor(private activatedRoute: ActivatedRoute) { }

  ngOnInit() {
    this.id != this.activatedRoute.snapshot.paramMap.get('id');
    // Aquí deberías obtener los detalles del curso según el id y asignarlos a las propiedades curso y puntos.
  }

}
