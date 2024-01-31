import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { PaginaDetallesPage } from './pagina-detalles.page';

const routes: Routes = [
  {
    path: '',
    component: PaginaDetallesPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PaginaDetallesPageRoutingModule {}
