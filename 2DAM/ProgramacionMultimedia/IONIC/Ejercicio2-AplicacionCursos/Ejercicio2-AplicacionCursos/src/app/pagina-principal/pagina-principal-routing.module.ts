import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PaginaPrincipalPage } from './pagina-principal.page';

const routes: Routes = [
  {
    path: '',
    component: PaginaPrincipalPage
  },
  {
    path: 'anadir-form',
    loadChildren: () => import('./anadir-form/anadir-form.module').then( m => m.AnadirFormPageModule)
  },
  {
    path: 'item-curso',
    loadChildren: () => import('./item-curso/item-curso.module').then( m => m.ItemCursoPageModule)
  },
  {
    path: 'pagina-detalles',
    loadChildren: () => import('./pagina-detalles/pagina-detalles.module').then( m => m.PaginaDetallesPageModule)
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PaginaPrincipalPageRoutingModule {}
