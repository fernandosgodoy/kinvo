import { Injectable } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/auth';
import { Router } from '@angular/router';
// import { auth } from 'firebase';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private authState: any = null;

  constructor(
    private afu = AngularFireAuth,
    private router = Router
    ) { 
    
    }

  signIn(){
    
  }

}
