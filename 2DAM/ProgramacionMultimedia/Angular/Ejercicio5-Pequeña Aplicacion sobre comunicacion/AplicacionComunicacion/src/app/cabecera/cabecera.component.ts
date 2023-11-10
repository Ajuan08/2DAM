import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-cabecera',
  templateUrl: './cabecera.component.html',
  styleUrls: ['./cabecera.component.css']
})
export class CabeceraComponent {

  @Output() idLibro = new EventEmitter<any>();
  @Input() libros!: any;

  emitirIdLibro(id: Number){
    this.idLibro.emit(id);
  }
}
