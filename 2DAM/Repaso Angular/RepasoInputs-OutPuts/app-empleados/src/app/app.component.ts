import { Component } from '@angular/core';
import { Empleado } from './empleado.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  titulo = 'Listado de empleados';
  cuadroNombre:string = "";
  cuadroApellido:string = "";
  cuadroCargo:string = "";
  cuadroSalario:number = 0;

  empleados:Empleado[] = [

    new Empleado('Juan', 'Perez', 'Contador', 1000),
    new Empleado('Maria', 'Lopez', 'Administrativa', 1200),
    new Empleado('Carlos', 'Gonzalez', 'Programador', 1500),
  ];

  agregarEmpleado(){

    let miEmpleado = new Empleado(this.cuadroNombre, this.cuadroApellido, this.cuadroCargo, this.cuadroSalario);
    this.empleados.push(miEmpleado);
  }

  
}
