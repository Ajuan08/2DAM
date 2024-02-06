import { Component, Input, OnInit } from '@angular/core';
import { NavController } from '@ionic/angular';

@Component({
  selector: 'app-lista-cursos',
  templateUrl: './lista-cursos.component.html',
  styleUrls: ['./lista-cursos.component.scss'],
})
export class ListaCursosComponent  implements OnInit {

  @Input() cursos: any;

  constructor(private navCtrl: NavController) { }

  ngOnInit() {}


  cambioPagina(curso: any) {
    this.navCtrl.navigateForward(`/detalles/${curso.id}`);
  }

}
