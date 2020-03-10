import { TestBed } from '@angular/core/testing';

import { AlertifyjsService } from './alertifyjs.service';

describe('AlertifyjsService', () => {
  let service: AlertifyjsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AlertifyjsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
