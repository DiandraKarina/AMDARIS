import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AlertifyService } from 'src/app/services/alertify.service';
import { AuthService } from 'src/app/services/auth.service';
import { EncryptionService } from 'src/app//services/encryption.service';
import {
  FormBuilder,
  FormGroup,
  Validators,
} from '@angular/forms';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit{
  myForm!: FormGroup;
 hide=true;
  constructor(private formBuilder: FormBuilder,
              private authService: AuthService,
              private alertify: AlertifyService,
              private router: Router) {

  }

  ngOnInit() {
    this.myForm = this.formBuilder.group({
      email: ['', [Validators.required, Validators.email]],
      password: [
        '',
        [
          Validators.required,
          Validators.pattern('^(?=.*[a-z])(?=.*[A-Z])(?=.*d)[a-zA-Zd]{8,}$'),
        ]]
    })
}

onLogin(loginForm: NgForm) {
  let UserArray = [];
  if (this.authService.getAllUsers()) {
    this.authService.getAllUsers().subscribe(data => {
      UserArray = data;
      console.log(UserArray)

      console.log(loginForm.value);
      const token = this.authService.authUser(loginForm.value, UserArray);
      console.log(token);
      if(token){
        if(!token.ban){
          localStorage.setItem('token', token.userName);
          localStorage.setItem('email', token.email);
          localStorage.setItem('admin', token.admin);
          localStorage.setItem('id', token.id);
          this.alertify.success("Login Successfull");
          this.router.navigate(['/home']);
        } else {
          this.alertify.error("You have been banned");
        }

      } else {
        this.alertify.error("Login unsuccessfull");
      }
    });
  } else {
    this.alertify.error("Login unsuccessfull");
  }
}

get email() {
  return this.myForm.get('email');
}

get password() {
  return this.myForm.get('password');
}
}
