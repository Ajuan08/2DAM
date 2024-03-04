import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CabeceraComponent } from './cabecera/cabecera/cabecera.component';
import { FondoComponent } from './fondo/fondo/fondo.component';
import { PanelComponent } from './panel/panel/panel.component';
import { TuberiaPipe } from './tuberia/tuberia.pipe';

@NgModule({
  declarations: [
    AppComponent,
    CabeceraComponent,
    FondoComponent,
    PanelComponent,
    TuberiaPipe
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
