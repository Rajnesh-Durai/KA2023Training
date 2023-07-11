import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddfruitComponent } from './addfruit.component';

describe('AddfruitComponent', () => {
  let component: AddfruitComponent;
  let fixture: ComponentFixture<AddfruitComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddfruitComponent]
    });
    fixture = TestBed.createComponent(AddfruitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
