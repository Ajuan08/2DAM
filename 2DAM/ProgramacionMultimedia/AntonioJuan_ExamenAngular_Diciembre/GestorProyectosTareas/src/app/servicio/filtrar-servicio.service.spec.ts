import { TestBed } from '@angular/core/testing';

import { FiltrarServicioService } from './filtrar-servicio.service';

describe('FiltrarServicioService', () => {
  let service: FiltrarServicioService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FiltrarServicioService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
