import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

<<<<<<< HEAD:painel/src/app/app.module.ts
// import firebase module
import { AngularFireModule } from '@angular/fire';
import { AngularFireDatabaseModule } from '@angular/fire/database';
import { AngularFirestoreModule } from '@angular/fire/firestore';
import {environment} from '../environments/environment';

// import {AngularFireAuthModule} from '@angular/fire/auth';


// import { LoginComponent } from './pages/login/login.component';
=======
import { AngularFireModule } from '@angular/fire';
import { AngularFireDatabaseModule } from '@angular/fire/database';
import { AngularFirestoreModule } from '@angular/fire/firestore';
import { environment } from 'src/environments/environment';
import { LoginComponent } from './pages/login/login.component';
>>>>>>> d82c0ebe0652897c8f4383cfed32fb8c90758976:kinvo-app/src/app/app.module.ts

@NgModule({
  declarations: [
    AppComponent//,
    // LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AngularFireModule.initializeApp(environment.firebase),
    AngularFireDatabaseModule,
    AngularFirestoreModule,
<<<<<<< HEAD:painel/src/app/app.module.ts
    AppRoutingModule,

  ],
  providers: [
=======
    FormsModule
>>>>>>> d82c0ebe0652897c8f4383cfed32fb8c90758976:kinvo-app/src/app/app.module.ts
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
