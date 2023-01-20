import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import{HomeComponent} from './components/home/home/home.component'
import { LoginComponent } from './components/login/login.component';
import { ProfileComponent } from './components/profile-page/profile/profile.component';
import {RegisterComponent} from './components/register/register.component';
import { StatusComponent } from './components/status/status.component';
import { BlogpostComponent } from './components/profile-page/blogpost/blogpost.component';
import { NewPostComponent } from './components/profile-page/new-post/new-post.component';
import { WelcomeComponent } from './components/welcome/welcome.component';
import { Navbar2Component } from './components/navbar2/navbar2.component';
import { AboutComponent } from './components/about/about.component';
import { FooterComponent } from './components/home/footer/footer.component';
import { BlogComponent } from './components/blog/blog.component';
const routes: Routes = [
  { path: ' ', component: HomeComponent },
  {path:'about',component: AboutComponent},
  { path: 'register', component: RegisterComponent },
  {path: 'login', component: LoginComponent},
  {path:'profile', component: ProfileComponent},
  {path:'blogpost', component: BlogpostComponent},
  {path:'newpost', component:NewPostComponent},
  {path:'welcome', component: WelcomeComponent},
  {path:'navbar', component: Navbar2Component},
  {path:'blog', component:BlogComponent},
  {path:'**', component: StatusComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
