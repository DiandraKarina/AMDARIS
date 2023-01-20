import { ListKeyManager } from '@angular/cdk/a11y';
import { Component, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Observable } from 'rxjs';
import { AuthService } from 'src/app/services/auth.service';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  myForm!: FormGroup;
  hide = true;
  constructor(private formBuilder: FormBuilder, private authService:AuthService) {

  }

  ngOnInit() {
    this.myForm = this.formBuilder.group({
      firstName: ['', [Validators.required]],
      lastName: ['', [Validators.required]],
      email: ['', [Validators.required, Validators.email]],
      blogName: ['', [Validators.required]],
      facebook:['',Validators.pattern('/^http(s*):\/\/(www.)*facebook\.com\/[a-zA-Z0-9.]+$/i')],
      instagram:[''],
      dob:[
        '',
        [
          Validators.required,
          Validators.minLength(2),
          Validators.min(14),
          Validators.max(65),
        ],
      ],
      password: [
        '',
        [
          Validators.required,
          Validators.pattern('^(?=.*[a-z])(?=.*[A-Z])(?=.*d)[a-zA-Zd]{8,}$'),
        ],
      ],
      gender: ['']
    });
    this.myForm.valueChanges.subscribe(console.log);
  }

  registerSubmitted(){
    this.authService.registerUser([
      this.myForm.value.firstName,
      this.myForm.value.lastName,
      this.myForm.value.blogName,
      this.myForm.value.email,
      this.myForm.value.password,
      this.myForm.value.facebook,
      this.myForm.value.instagram,
      this.myForm.value.pinterest,
      this.myForm.value.dob,
      this.myForm.value.gender
    ]).subscribe(res=>{console.log(res);
    })
  }
  get firstName() {
    return this.myForm.get('firstName');
  }
  get lastName() {
    return this.myForm.get('lastName');
  }

  get blogName() {
    return this.myForm.get('blogName');
  }

  get email() {
    return this.myForm.get('email');
  }

  get password() {
    return this.myForm.get('password');
  }

 get facebook_link(){
  return this.myForm.get('facebook');
 }
 get instagram_link(){
  return this.myForm.get('instagram');
 }
 get pinterest_link(){
  return this.myForm.get('pinterest');
 }
  //get dateOfBirth() {
  //  if(this.myForm.get('dob') !=null)
   //  return this.myForm.get('dob').value || new Date()}


  //get age() {  return new Date().getFullYear() - this.dateOfBirth.getFullYear()}

}
