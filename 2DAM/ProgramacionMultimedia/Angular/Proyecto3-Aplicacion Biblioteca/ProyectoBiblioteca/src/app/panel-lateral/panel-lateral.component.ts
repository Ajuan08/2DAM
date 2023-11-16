import { Component } from '@angular/core';

@Component({
  selector: 'app-panel-lateral',
  templateUrl: './panel-lateral.component.html',
  styleUrls: ['./panel-lateral.component.css']
})
export class PanelLateralComponent {
  mostrarComponentes = false;

  login(){
    this.mostrarComponentes = true;
  }
}

