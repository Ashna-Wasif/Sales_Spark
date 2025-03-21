import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SecurityMonitoringComponent } from './security-monitoring.component';

describe('SecurityMonitoringComponent', () => {
  let component: SecurityMonitoringComponent;
  let fixture: ComponentFixture<SecurityMonitoringComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [SecurityMonitoringComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SecurityMonitoringComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
