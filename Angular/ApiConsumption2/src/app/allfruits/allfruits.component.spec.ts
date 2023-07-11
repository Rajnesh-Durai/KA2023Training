import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AllfruitsComponent } from './allfruits.component';

describe('AllfruitsComponent', () => {
  let component: AllfruitsComponent;
  let fixture: ComponentFixture<AllfruitsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AllfruitsComponent]
    });
    fixture = TestBed.createComponent(AllfruitsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
