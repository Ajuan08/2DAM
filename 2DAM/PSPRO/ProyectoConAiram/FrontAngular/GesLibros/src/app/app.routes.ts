import { Routes } from '@angular/router';
import { AutorFormComponent } from './autor-form/autor-form.component';
import { CategoriaFormComponent } from './categoria-form/categoria-form.component';
import { LibroFormComponent } from './libro-form/libro-form.component';

export const routes: Routes = [
    { path: 'IrAutorForm', component: AutorFormComponent },
    { path: 'IrCategoriaForm', component: CategoriaFormComponent },
    { path: 'IrLibroForm', component: LibroFormComponent },

];
