import { ComponentFixture, TestBed } from '@angular/core/testing';
import { AnadirFormPage } from './anadir-form.page';

describe('AnadirFormPage', () => {
  let component: AnadirFormPage;
  let fixture: ComponentFixture<AnadirFormPage>;

  beforeEach(async(() => {
    fixture = TestBed.createComponent(AnadirFormPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
