import { TestBed } from '@angular/core/testing';

import { CrudSchoolService } from './crud-school.service';

describe('CrudSchoolService', () => {
  let service: CrudSchoolService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CrudSchoolService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
