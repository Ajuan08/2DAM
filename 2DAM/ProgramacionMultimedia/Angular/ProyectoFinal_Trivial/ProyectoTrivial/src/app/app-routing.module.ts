import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { PreguntasComponent } from './preguntas/preguntas.component';
import { AppComponent } from './app.component';
import { LoginGuard } from './login-guard.guard';

const routes: Routes = [
  {path: 'login', component: LoginComponent},
  {path: 'preguntas', component: PreguntasComponent,canActivate: [LoginGuard]},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
