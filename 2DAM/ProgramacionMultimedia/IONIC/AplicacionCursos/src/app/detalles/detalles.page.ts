import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NavController, NavParams } from '@ionic/angular';
import { ServicioService } from '../servicio/servicio.service';

@Component({
  selector: 'app-detalles',
  templateUrl: './detalles.page.html',
  styleUrls: ['./detalles.page.scss'],
})
export class DetallesPage implements OnInit {

  curso: any;

  constructor(private route: ActivatedRoute, private servicio: ServicioService) {
    this.route.params.subscribe(params => {
      const cursoId = params['cursoId'];
      this.curso = this.servicio.buscarCursoId(cursoId);
    });
  }

  ngOnInit() {

  }
  
  eliminarCurso(curso:any){
   this.servicio.eliminarCurso(curso.id);
  }


}
