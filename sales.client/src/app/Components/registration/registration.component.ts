import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';  

@Component({
  selector: 'app-registration',
  standalone: false,
  templateUrl: './registration.component.html',
  styleUrl: './registration.component.css'
})
export class RegistrationComponent {
  email: string = '';
  password: string = '';

  constructor(private http: HttpClient) { }

  login() {
    const user = { user_Email: this.email, user_Password: this.password };

    this.http.post('http://localhost:5000/api/user/login', user).subscribe(
      response => {
        console.log('Login Successful', response);
      },
      error => {
        console.log('Login Failed', error);
      }
    );
  }
}
