import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PrincipalComponent } from './principal/principal.component';
import { ListaAlumnosComponent } from './lista-alumnos/lista-alumnos.component';

const routes: Routes = [
  {path: '', redirectTo: '/principal', pathMatch: 'full'},
  {path: 'principal', component: PrincipalComponent},
  {path: 'listaAlumnos', component: ListaAlumnosComponent},
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
