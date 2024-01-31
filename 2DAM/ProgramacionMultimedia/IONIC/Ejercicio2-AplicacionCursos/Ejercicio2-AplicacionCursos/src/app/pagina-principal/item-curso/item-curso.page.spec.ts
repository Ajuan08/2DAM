import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ItemCursoPage } from './item-curso.page';

describe('ItemCursoPage', () => {
  let component: ItemCursoPage;
  let fixture: ComponentFixture<ItemCursoPage>;

  beforeEach(async(() => {
    fixture = TestBed.createComponent(ItemCursoPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
