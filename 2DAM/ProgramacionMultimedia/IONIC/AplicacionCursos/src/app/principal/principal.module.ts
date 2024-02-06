import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { PrincipalPageRoutingModule } from './principal-routing.module';

import { PrincipalPage } from './principal.page';

import { FormularioComponent } from '../formulario/formulario.component';
import { ListaCursosComponent } from '../lista-cursos/lista-cursos.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    PrincipalPageRoutingModule,
    ReactiveFormsModule
  ],
  declarations: [PrincipalPage, FormularioComponent, ListaCursosComponent]
})
export class PrincipalPageModule {}
