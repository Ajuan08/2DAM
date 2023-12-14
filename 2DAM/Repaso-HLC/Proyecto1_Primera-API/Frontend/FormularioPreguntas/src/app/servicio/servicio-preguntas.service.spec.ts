import { TestBed } from '@angular/core/testing';

import { ServicioPreguntasService } from './servicio-preguntas.service';

describe('ServicioPreguntasService', () => {
  let service: ServicioPreguntasService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ServicioPreguntasService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
