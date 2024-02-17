import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
{
  path: '',
  redirectTo: 'home',
  pathMatch: 'full'
},
{
  path: 'home',
  children: [
    {
      path: '',
      loadChildren: () => import('./home/home.module').then( m => m.HomePageModule)
    },
    {
      path: ':homeId',
      loadChildren: () => import('./home/detalles/detalles-routing.module').then( m => m.DetallesPageRoutingModule)
    },
  ]
},
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
