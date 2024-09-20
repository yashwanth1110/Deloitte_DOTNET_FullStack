import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeptDataComponent } from './dept-data.component';

describe('DeptDataComponent', () => {
  let component: DeptDataComponent;
  let fixture: ComponentFixture<DeptDataComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DeptDataComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DeptDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
