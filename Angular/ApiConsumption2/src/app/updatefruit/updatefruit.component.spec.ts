import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdatefruitComponent } from './updatefruit.component';

describe('UpdatefruitComponent', () => {
  let component: UpdatefruitComponent;
  let fixture: ComponentFixture<UpdatefruitComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UpdatefruitComponent]
    });
    fixture = TestBed.createComponent(UpdatefruitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
