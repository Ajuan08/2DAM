import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-categoria-form',
  standalone: true,
  imports: [],
  templateUrl: './categoria-form.component.html',
  styleUrl: './categoria-form.component.css'
})
export class CategoriaFormComponent {
  nombre: string = '';

  constructor(private router: Router) {}

  guardarCategoria() {
    console.log('Categoría guardada:', this.nombre);

    this.router.navigate(['/']);
  }
}
