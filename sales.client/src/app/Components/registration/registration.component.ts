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
  name: string = '';
  number: string = '';
  Cpassword: string = '';

  constructor(private http: HttpClient) { }

  signup() {
    if (this.password == this.Cpassword) {
      const user = { user_Email: this.email, user_Password: this.password, user_name: this.name, user_Contact: this.number };

      this.http.post('https://localhost:7170/signup', user).subscribe(
        response => {
          console.log('User Added Successfully', response);
        },
        error => {
          console.log('Registration Failed', error);
        }
      );
    }
    else {
      console.log("Password Mismatched.");
    }
  }
}
