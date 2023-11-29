import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { PreguntasComponent } from './preguntas/preguntas.component';

const routes: Routes = [
  {path: 'login', component: LoginComponent},
  {path: 'preguntas', component: PreguntasComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
