import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { PersonaService } from '../../persona.service';
import { AlertController } from '@ionic/angular';

@Component({
  selector: 'app-formulario',
  templateUrl: './formulario.component.html',
  styleUrls: ['./formulario.component.scss'],
})
export class FormularioComponent implements OnInit {

  formulario: FormGroup;

  constructor(private personaService: PersonaService,public alertController: AlertController) {
    this.formulario = new FormGroup({
      nombre: new FormControl('', Validators.required),
      puntos: new FormControl('', Validators.required)
    });
  }

  ngOnInit() {}

  async onSubmit() {
    if (this.formulario.invalid) {
      const alert = await this.alertController.create({
        header: 'Error',
        message: 'Por favor rellena todos los campos.',
        buttons: ['OK']
      });
      await alert.present();
    } else {
      this.personaService.agregarDatos(this.formulario.value);
    }
  }

}
