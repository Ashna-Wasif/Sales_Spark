import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomepageComponent } from './Components/homepage/homepage.component';
import { LoginComponent } from './Components/login/login.component';
import { RegistrationComponent } from './Components/registration/registration.component';
import { AuditorPageComponent } from './Components/Auditor/auditor-page/auditor-page.component';
import { AdminDashboardComponent } from './Components/admin-dashboard/admin-dashboard.component';
import { AccessLogsComponent } from './Components/Auditor/access-logs/access-logs.component';
import { AlertsComponent } from './Components/Auditor/alerts/alerts.component';
import { ReportsComponent } from './Components/Auditor/reports/reports.component';
import { SecurityMonitoringComponent } from './Components/Auditor/security-monitoring/security-monitoring.component';
import { SettingsComponent } from './Components/Auditor/settings/settings.component';
import { UserLogsComponent } from './Components/Auditor/user-logs/user-logs.component';
import { AuditorNavbarComponent } from './Components/Auditor/auditor-navbar/auditor-navbar.component';

const routes: Routes = [
  { path: '', component: HomepageComponent },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegistrationComponent },

  {
    path: 'auditor', component: AuditorNavbarComponent,
    children: [
      { path: '', component: AuditorPageComponent }, 
      { path: 'user-logs', component: UserLogsComponent },
      { path: 'security-monitoring', component: SecurityMonitoringComponent },
      { path: 'access-logs', component: AccessLogsComponent },
      { path: 'reports', component: ReportsComponent },
      { path: 'alerts', component: AlertsComponent },
      { path: 'settings', component: SettingsComponent }
    ]
  },



  { path: 'admin', component: AdminDashboardComponent },


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
