import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CabeceraComponent } from './cabecera/cabecera.component';
import { Cabecera1Component } from './cabecera1/cabecera1.component';
import { Cabecera2Component } from './cabecera2/cabecera2.component';

@NgModule({
  declarations: [
    AppComponent,
    CabeceraComponent,
    Cabecera1Component,
    Cabecera2Component
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
