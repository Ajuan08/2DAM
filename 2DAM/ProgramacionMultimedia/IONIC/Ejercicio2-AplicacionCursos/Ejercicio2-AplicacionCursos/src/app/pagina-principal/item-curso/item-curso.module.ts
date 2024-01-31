import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ItemCursoPageRoutingModule } from './item-curso-routing.module';

import { ItemCursoPage } from './item-curso.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ItemCursoPageRoutingModule
  ],
  declarations: [ItemCursoPage]
})
export class ItemCursoPageModule {}
