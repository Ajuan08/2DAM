import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ServicioDescripcionService } from '../servicios/servicioDescripcion/servicio-descripcion.service';

@Component({
  selector: 'app-pagina-detalle',
  templateUrl: './pagina-detalle.component.html',
  styleUrls: ['./pagina-detalle.component.css']
})
export class PaginaDetalleComponent implements OnInit {
  public nombre!: string
  public edad!: number
  public mensaje!: string

  public dinero: number = 0

  public descripcion!: string

  constructor(private activatedRouter: ActivatedRoute, private descripcionService: ServicioDescripcionService) { }

  ngOnInit(): void {
    this.activatedRouter.params.subscribe(params => {
      this.nombre = params['nombre']
      this.edad = params['edad']
      this.mensaje = params['mensaje']
    })

    this.descripcionService.getDescripcion$().subscribe(descripcion => {
      this.descripcion = descripcion
    })
  }

  recogerDinero(dinero: number) {
    this.dinero = dinero
  }


}
