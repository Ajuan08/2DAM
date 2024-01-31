import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { AnadirFormPageRoutingModule } from './anadir-form-routing.module';

import { AnadirFormPage } from './anadir-form.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    AnadirFormPageRoutingModule
  ],
  declarations: [AnadirFormPage]
})
export class AnadirFormPageModule {}
