import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegistrationComponent } from './Components/registration/registration.component';
import { LoginComponent } from './Components/login/login.component';
import { HomepageComponent } from './Components/homepage/homepage.component';
import { AuditorPageComponent } from './Components/Auditor/auditor-page/auditor-page.component';
import { UsersProfileComponent } from './Components/users-profile/users-profile.component';
import { AdminDashboardComponent } from './Components/admin-dashboard/admin-dashboard.component';
import { AuditorNavbarComponent } from './Components/Auditor/auditor-navbar/auditor-navbar.component';
import { UserLogsComponent } from './Components/Auditor/user-logs/user-logs.component';
import { SecurityMonitoringComponent } from './Components/Auditor/security-monitoring/security-monitoring.component';
import { AccessLogsComponent } from './Components/Auditor/access-logs/access-logs.component';
import { ReportsComponent } from './Components/Auditor/reports/reports.component';
import { AlertsComponent } from './Components/Auditor/alerts/alerts.component';
import { SettingsComponent } from './Components/Auditor/settings/settings.component';

@NgModule({
  declarations: [
    AppComponent,
    RegistrationComponent,
    LoginComponent,
    HomepageComponent,
    AuditorPageComponent,
    UsersProfileComponent,
    AdminDashboardComponent,
    AuditorNavbarComponent,
    UserLogsComponent,
    SecurityMonitoringComponent,
    AccessLogsComponent,
    ReportsComponent,
    AlertsComponent,
    SettingsComponent
  ],
  exports:
    [
      AuditorPageComponent
    ],
  imports: [
    BrowserModule, HttpClientModule, FormsModule, 
    FontAwesomeModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
