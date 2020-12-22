import { Injectable } from '@angular/core';
import { AngularFireAuthModule } from '@angular/fire/auth';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private angularFireAuth = AngularFireAuthModule) { }

  signIn(){
    
  }

}
