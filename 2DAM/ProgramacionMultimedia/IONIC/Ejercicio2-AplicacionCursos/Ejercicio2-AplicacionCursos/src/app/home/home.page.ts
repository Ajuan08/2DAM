
import { Component } from '@angular/core';
import { CursoService } from '../services/curso.service';
import { NavController } from '@ionic/angular';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {
  nuevoCurso = '';
  nuevosPuntos: number;
  cursos: string[];

  constructor(private cursoService: CursoService, private navCtrl: NavController) {}

  ngOnInit() {
    this.cursoService.cursos$.subscribe(cursos => {
      this.cursos = cursos;
    });
  }

  agregarCurso() {
    if (this.nuevoCurso && this.nuevosPuntos) {
      const curso = `${this.nuevoCurso} - ${this.nuevosPuntos} puntos`;
      this.cursoService.agregarCurso(curso);
    } else {
      // Muestra una alerta si los campos están vacíos
      console.log('Error: Todos los campos deben ser llenados');
    }
  }

  verDetalles(curso: string) {
    // Navega a la página de detalles con el nombre del curso
    this.navCtrl.navigateForward(`/detalles/${curso}`);
  }
}
