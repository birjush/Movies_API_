import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder,Validators } from '@angular/forms';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent {
  type:string = "password";
  isText:boolean = false;
  eyeIcon:string = "fa-eye-slash";
  loginform!:FormGroup;

  constructor(private fb : FormBuilder){}

  ngOnInit():void{
    this.loginform = this.fb.group({
      email:['',Validators.required],
      password:['',Validators.required]
    })
  }

  hideShowPass(){
    this.isText = !this.isText;
    this.isText ? this.eyeIcon = "fa-eye" : this.eyeIcon = "fa-eye-slash";
    this.isText ? this.type = "text" : this.type = "password";
    console.log("clicked");
  }
}
