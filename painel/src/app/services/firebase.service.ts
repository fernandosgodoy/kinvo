import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/auth';
import { userInfo } from 'os';

@Injectable({
  providedIn: 'root'
})
export class FirebaseService {

  isLoggedIn = false;

  constructor(public firebaseAuth = AngularFireAuth) { }

  async signin(email: string, password: string) {
    await this.firebaseAuth.signInWithEmailAndPassword(email, password)
      .then(r => {
        this.isLoggedIn = true;
        localStorage.setItem('user', JSON.stringify(r.user));
      });
  }

  logout() {
    this.firebaseAuth.signOut();
    localStorage.removeItem('user');
  }
}
