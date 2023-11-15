import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CabeceraComponent } from './cabecera/cabecera.component';
import { PanelLateralComponent } from './panel-lateral/panel-lateral.component';
import { ListaLibrosComponent } from './lista-libros/lista-libros.component';

@NgModule({
  declarations: [
    AppComponent,
    CabeceraComponent,
    PanelLateralComponent,
    ListaLibrosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
