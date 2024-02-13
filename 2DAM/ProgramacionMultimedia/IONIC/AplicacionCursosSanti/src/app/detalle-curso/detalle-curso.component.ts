import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { NavController } from '@ionic/angular';

@Component({
  selector: 'app-detalle-curso',
  templateUrl: './detalle-curso.component.html',
  styleUrls: ['./detalle-curso.component.scss'],
})
export class DetalleCursoComponent  implements OnInit {

  @Input() curso: any;
  @Output() eliminarCurso:any = new EventEmitter<any>();

  constructor(private navCtrl: NavController) {
   }

  ngOnInit() {}

  

  cambiarPrincipal() {
    console.log('Contenido del objeto curso:', this.curso);
    this.navCtrl.navigateForward('/principal');
  }

  eliminar(){
    this.eliminarCurso.emit(this.curso)
    this.navCtrl.navigateForward('/principal');
  }
}
