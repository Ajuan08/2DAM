import { Component, ElementRef, ViewChild } from '@angular/core';

@Component({
  selector: 'app-cabecera2',
  templateUrl: './cabecera2.component.html',
  styleUrls: ['./cabecera2.component.css']
})
export class Cabecera2Component {
  direccionImagen! : string;
  @ViewChild('childImage') childImage!: ElementRef;
}
