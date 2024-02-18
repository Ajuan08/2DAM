import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Curso } from '../classes/curso';

@Component({
  selector: 'app-detalle',
  templateUrl: './detalle.page.html',
  styleUrls: ['./detalle.page.scss'],
})
export class DetallePage implements OnInit {

  curso!: Curso;

  constructor(private router: ActivatedRoute) {}

  ngOnInit() {
    this.router.params.subscribe((params) => {
      const cursoJson = params['curso'];
      const cursoObj = JSON.parse(cursoJson);
      this.curso = new Curso(cursoObj.nombre, cursoObj.puntos);
    }) 
  }
}
