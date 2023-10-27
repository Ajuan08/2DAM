import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Cabecera1Component } from './cabecera1.component';

describe('Cabecera1Component', () => {
  let component: Cabecera1Component;
  let fixture: ComponentFixture<Cabecera1Component>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [Cabecera1Component]
    });
    fixture = TestBed.createComponent(Cabecera1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
