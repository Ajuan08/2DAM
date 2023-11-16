import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-cabecera',
  templateUrl: './cabecera.component.html',
  styleUrls: ['./cabecera.component.css']
})
export class CabeceraComponent {
  @Output() loginEvent = new EventEmitter();

  login() {
    this.loginEvent.emit();
  }

}
