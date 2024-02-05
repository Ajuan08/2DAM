import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-autor-form',
  standalone: true,
  imports: [],
  templateUrl: './autor-form.component.html',
  styleUrl: './autor-form.component.css'
})
export class AutorFormComponent {
  nombre: string = '';

  constructor(private router:Router ) {}

  guardarAutor() {
    console.log('Guardando autor: ' + this.nombre);
    this.router.navigate(['/']);
  }

}
