import { Component } from '@angular/core';
import {NgForm} from '@angular/forms';
import { FirebaseService } from './services/firebase.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'painel';
  isSignedIn = false;

  constructor(public firebaseService: FirebaseService){ }
 
  // ngOnInit() {
  //   if (localStorage.getItem('user') !== null)
  //     this.isSignedIn = true;
  //   else
  //     this.isSignedIn = false;
  // }

  // async entrar(email: string, senha: string) {
  //   console.log(email, senha);
  //   await this.firebaseService.signin(email, senha)
  //     .then(r => {
  //       if (this.firebaseService.isLoggedIn)
  //         this.isSignedIn = true;
  //     });
  // }

}
