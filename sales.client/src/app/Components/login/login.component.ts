import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-login',
  standalone: false,
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  email: string = '';
  password: string = '';

  constructor(private http: HttpClient) { }

  login() {
    const user = { user_Email: this.email, user_Password: this.password };

    this.http.post('https://localhost:7170/login', user).subscribe(
      response => {
        console.log('Login Successful', response);
      },
      error => {
        console.log('Login Failed', error);
      }
    );
  }
}
