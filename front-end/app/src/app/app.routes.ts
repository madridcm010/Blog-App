import { Routes } from '@angular/router';
import { HomeComponent } from '../home/home.component';
import { ArticlesComponent } from '../articles/articles.component';
import { ContactComponent } from '../contact/contact.component';
import { LoginComponent } from '../login/login.component';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'Articles', component: ArticlesComponent},
  { path: 'Contact', component: ContactComponent },
  { path: 'Login', component: LoginComponent }
];

