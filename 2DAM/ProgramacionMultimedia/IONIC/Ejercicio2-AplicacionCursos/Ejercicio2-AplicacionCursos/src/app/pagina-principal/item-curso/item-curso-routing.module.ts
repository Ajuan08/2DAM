import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ItemCursoPage } from './item-curso.page';

const routes: Routes = [
  {
    path: '',
    component: ItemCursoPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ItemCursoPageRoutingModule {}
