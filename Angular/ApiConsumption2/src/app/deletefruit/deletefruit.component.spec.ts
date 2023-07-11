import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletefruitComponent } from './deletefruit.component';

describe('DeletefruitComponent', () => {
  let component: DeletefruitComponent;
  let fixture: ComponentFixture<DeletefruitComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeletefruitComponent]
    });
    fixture = TestBed.createComponent(DeletefruitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
