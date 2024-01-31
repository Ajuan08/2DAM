import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { PaginaDetallesPageRoutingModule } from './pagina-detalles-routing.module';

import { PaginaDetallesPage } from './pagina-detalles.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    PaginaDetallesPageRoutingModule
  ],
  declarations: [PaginaDetallesPage]
})
export class PaginaDetallesPageModule {}
