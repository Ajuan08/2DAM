import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DetalleCursoComponent } from './detalle-curso/detalle-curso/detalle-curso.component';
import { FormularioComponent } from './formulario/formulario.component';
import { ListaCursosComponent } from './lista-cursos/lista-cursos.component';
import { DetallesComponent } from './detalles/detalles.component';

@NgModule({
  declarations: [
    AppComponent,
    DetalleCursoComponent,
    FormularioComponent,
    ListaCursosComponent,
    DetallesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
