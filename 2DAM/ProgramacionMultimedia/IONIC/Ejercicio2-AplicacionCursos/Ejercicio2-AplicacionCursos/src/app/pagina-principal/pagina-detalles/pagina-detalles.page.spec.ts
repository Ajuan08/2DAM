import { ComponentFixture, TestBed } from '@angular/core/testing';
import { PaginaDetallesPage } from './pagina-detalles.page';

describe('PaginaDetallesPage', () => {
  let component: PaginaDetallesPage;
  let fixture: ComponentFixture<PaginaDetallesPage>;

  beforeEach(async(() => {
    fixture = TestBed.createComponent(PaginaDetallesPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
