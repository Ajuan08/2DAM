import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { DetallesPageRoutingModule } from './detalles-routing.module';

import { DetallesPage } from './detalles.page';
import { DetalleCursoComponent } from '../detalle-curso/detalle-curso.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    DetallesPageRoutingModule
  ],
  declarations: [DetallesPage, DetalleCursoComponent]
})
export class DetallesPageModule {}
