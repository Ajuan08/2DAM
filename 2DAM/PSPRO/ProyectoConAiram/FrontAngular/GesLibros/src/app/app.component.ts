import { Component } from '@angular/core';
import { Router, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'GesLibros';

  constructor(private router: Router ) {}

  irAutorForm() {
    this.router.navigate(['/IrAutorForm']);
  }

  irCategoriaForm() {
    this.router.navigate(['/IrCategoriaForm']);
  }

  irLibroForm() {
    this.router.navigate(['/IrLibroForm']);
  }
}
