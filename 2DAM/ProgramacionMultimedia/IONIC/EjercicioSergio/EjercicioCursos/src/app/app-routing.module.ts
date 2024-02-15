import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';
import { DetallesCursoPage } from './detalles-curso/detalles-curso.page';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'lista-cursos',
    pathMatch: 'full'
  },
  {
    path: 'lista-cursos',
    loadChildren: () => import('./lista-cursos/lista-cursos.module').then( m => m.ListaCursosPageModule)
  },
  {
    path: 'detalles-curso/:id',
    component: DetallesCursoPage
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }