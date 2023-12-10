import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { DirectivaPersonalizadaDirective } from './directiva-personalizada.directive';
import { MainComponent } from './main/main.component';

@NgModule({
  declarations: [
    AppComponent,
    DirectivaPersonalizadaDirective,
    MainComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
