import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AlertController } from '@ionic/angular';
import { PersonaService } from 'src/app/persona.service';

@Component({
  selector: 'app-detalles',
  templateUrl: './detalles.page.html',
  styleUrls: ['./detalles.page.scss'],
})
export class DetallesPage implements OnInit {

  dato: any;

  constructor(private personaService: PersonaService, private activatedRoute: ActivatedRoute, private router: Router, private alertCtrl: AlertController) 
  {}

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe(paramMap => {
      if (!paramMap.has('homeId')) {
        this.router.navigate(['/home']);
        return;
      }
      const id = paramMap.get('homeId');
      
      if (id) {
        this.dato = this.personaService.getCurso(id);
      }
    });
  }

  borrar(): void {
    this.alertCtrl
      .create({
        header: 'Borrar el curso',
        message: '¿Seguro que quiere borrar el curso?',
        buttons: [
          {
            text: 'Cancelar',
            role: 'cancel'
          },
          {
            text: 'Borrar',
            handler: () => {
              this.personaService.eliminarDatos(this.dato['id']);
              this.router.navigate(['/home']);
            }
          }
        ]
      })
      .then(alertEl => {
        alertEl.present();
      });
  }

}
