import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/home/navbar/navbar.component';
import { FooterComponent } from './components/home/footer/footer.component';
import { ButtonComponent } from './components/button/button.component';
import { BlogCardComponent } from './components/home/blog-card/blog-card.component';
import { SocialComponent } from './components/social/social.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatInputModule} from '@angular/material/input';
import {MatButtonModule} from '@angular/material/button';
import { LoginComponent } from './components/login/login.component';
import { BlogComponent } from './components/blog/blog.component';
import { HomeComponent } from './components/home/home/home.component';
import { RegisterComponent } from './components/register/register.component';
import {MatMenuModule} from '@angular/material/menu';
import { ProfileComponent } from './components/profile-page/profile/profile.component';
import { StatusComponent } from './components/status/status.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatListModule} from '@angular/material/list';
import {MatRadioModule} from '@angular/material/radio';
import {MatFormFieldModule} from '@angular/material/form-field';
import { MatNativeDateModule } from '@angular/material/core';
import {MatIconModule} from '@angular/material/icon';
import {MatCardModule} from '@angular/material/card';
import { HttpClientModule } from '@angular/common/http';
import { AuthService } from './services/auth.service';
import {MatExpansionModule} from '@angular/material/expansion';
import { BlogpostComponent } from './components/profile-page/blogpost/blogpost.component';
import { NewPostComponent } from './components/profile-page/new-post/new-post.component';
import { WelcomeComponent } from './components/welcome/welcome.component';
import { Navbar1Component } from './components/navbar1/navbar1.component';
import { ScrollTopComponent } from './components/scroll-top/scroll-top.component';
import { PostBoxComponent } from './components/post-box/post-box.component';
import { Navbar2Component } from './components/navbar2/navbar2.component';
import { LogoComponent } from './components/logo/logo.component';
import { AboutComponent } from './components/about/about.component';
import { RecipeBoxComponent } from './components/recipe-box/recipe-box.component';

@NgModule({
  declarations: [
    AppComponent,
    BlogCardComponent,
    SocialComponent,
    LoginComponent,
    HomeComponent,
    BlogComponent,
    ProfileComponent,
    StatusComponent,
    NavbarComponent,
    ButtonComponent,
    FooterComponent,
    RegisterComponent,
    BlogpostComponent,
    NewPostComponent,
    WelcomeComponent,
    Navbar1Component,
    ScrollTopComponent,
    PostBoxComponent,
    Navbar2Component,
    LogoComponent,
    AboutComponent,
    RecipeBoxComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatInputModule,
    MatButtonModule,
    MatMenuModule,
    ReactiveFormsModule,
        FormsModule,
        NgbModule,
        MatDatepickerModule,
        MatListModule,
        MatRadioModule,
        MatFormFieldModule,
        MatNativeDateModule,
        MatIconModule,
        MatCardModule,
        AppRoutingModule,
        HttpClientModule,
        MatExpansionModule
  ],
  providers: [AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }
