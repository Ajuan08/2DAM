import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-cabecera',
  templateUrl: './cabecera.component.html',
  styleUrls: ['./cabecera.component.css']
})
export class CabeceraComponent {
  @Output() loginEvent = new EventEmitter<void>();

  login() {
    this.loginEvent.emit();
  }

  mostrarComponentes(){
    this.mostrarComponentes = this.mostrarComponentes
  }
}
