
import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NavController } from '@ionic/angular';

@Component({
  selector: 'app-detalles',
  templateUrl: 'detalles.page.html',
  styleUrls: ['detalles.page.scss'],
})
export class DetallesPage {
  curso: string;

  constructor(private route: ActivatedRoute) {}

  ngOnInit() {
    // Obtén el nombre del curso de los parámetros de la URL
    this.curso = this.route.snapshot.paramMap.get('curso');
  }
}
