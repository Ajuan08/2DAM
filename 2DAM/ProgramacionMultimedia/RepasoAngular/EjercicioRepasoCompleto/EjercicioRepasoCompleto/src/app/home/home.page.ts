import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { LoginServiceService } from '../servicio/login-service.service';
import { Router } from '@angular/router';
import { CursoService } from '../servicio/curso.service';
import { BehaviorSubject } from 'rxjs';
import { Curso } from '../classes/curso';
import { NavController } from '@ionic/angular';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {

  cursoForm!:FormGroup;

  alertButtons = ["Aceptar"];

  listaCurso!: Curso[];

  constructor(private navCntrl: NavController, private cursoService: CursoService) {}

  ngOnInit() {
    this.cursoForm = new FormGroup({
      nombre: new FormControl('', [Validators.required]),
      puntos: new FormControl('', [Validators.required])
    });
    this.getCursos();
  }

  anadirCurso(){
  {
    this.cursoService.anadirCurso(this.cursoForm.value.nombre, this.cursoForm.value.puntos);
  }
}
  getCursos(){
    this.cursoService.getListaCursos$().subscribe((cursos) => {
      this.listaCurso = cursos;
    });
  }

  irDetalle(curso: Curso){
    const cursoJson = JSON.stringify(curso);
    this.navCntrl.navigateForward(`detalle/${cursoJson}`);
  }

}
