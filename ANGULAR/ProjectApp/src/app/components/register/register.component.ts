import { Component, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Observable } from 'rxjs';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent implements OnInit {
  myForm!: FormGroup;

  constructor(private formBuilder: FormBuilder) {

  }

  ngOnInit() {
    this.myForm = this.formBuilder.group({
      firstName: ['', [Validators.required]],
      lastName: ['', [Validators.required]],
      email: ['', [Validators.required, Validators.email]],
      blogName: ['', [Validators.required]],
      password: [
        '',
        [
          Validators.required,
          Validators.pattern('^(?=.*[a-z])(?=.*[A-Z])(?=.*d)[a-zA-Zd]{8,}$'),
        ],
      ],
      dob: [
        '',
        [
          Validators.required,
          Validators.minLength(2),
          Validators.min(14),
          Validators.max(65),
        ],
      ],
      gender: [''],
    });
    this.myForm.valueChanges.subscribe(console.log);
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


  //get dateOfBirth() {
  //  if(this.myForm.get('dob') !=null)
   //  return this.myForm.get('dob').value || new Date()}


  //get age() {  return new Date().getFullYear() - this.dateOfBirth.getFullYear()}

}
