import { Component, Input, OnInit } from '@angular/core';
import { Empleado } from '../empleado.model';

@Component({
  selector: 'app-empleado-hijo-c',
  templateUrl: './empleado-hijo-c.component.html',
  styleUrls: ['./empleado-hijo-c.component.css']
})
export class EmpleadoHijoCComponent implements OnInit {
  titulo = 'Listado de empleados';
  cuadroNombre:string = "";
  cuadroApellido:string = "";
  cuadroCargo:string = "";
  cuadroSalario:number = 0;


  @Input() empleadoDeLista!:Empleado;

  constructor() { }

  ngOnInit(): void {
  }

  empleados:Empleado[] = [

    new Empleado('Juan', 'Perez', 'Contador', 1000),
    new Empleado('Maria', 'Lopez', 'Administrativa', 1200),
    new Empleado('Carlos', 'Gonzalez', 'Programador', 1500),
  ];

  agregarEmpleado(){

    let miEmpleado = new Empleado(this.cuadroNombre, this.cuadroApellido, this.cuadroCargo, this.cuadroSalario);
    this.empleados.push(miEmpleado);
  }

  arrayCaracteristicas = [''];

  agregarCaracteristicas(nuevacaracteristicas: string) {
    this.arrayCaracteristicas.push(nuevacaracteristicas);
  }


}
