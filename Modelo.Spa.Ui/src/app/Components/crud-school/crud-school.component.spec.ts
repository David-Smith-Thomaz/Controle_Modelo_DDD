import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CrudSchoolComponent } from './crud-school.component';

describe('CrudSchoolComponent', () => {
  let component: CrudSchoolComponent;
  let fixture: ComponentFixture<CrudSchoolComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CrudSchoolComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CrudSchoolComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
