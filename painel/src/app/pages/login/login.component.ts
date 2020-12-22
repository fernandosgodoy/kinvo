import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  email: string="";
  senha: string="";
  errorMessage = "";
  error: { name: string, message: string } = { name: "", message: "" };

  constructor(private authService = AuthService) { }

  ngOnInit(): void {
  }

  login(){
    if (this.validateForm(this.email, this.senha)){

    }
  }

  validateForm(email: string, pass: string): boolean {
    return true;
  }

}
