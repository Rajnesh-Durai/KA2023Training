import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormControl, FormGroup,Validators} from '@angular/forms'
import { ValidateUrl } from './url.validator';

@Component({
  selector: 'app-reactive-forms',
  templateUrl: './reactive-forms.component.html',
  styleUrls: ['./reactive-forms.component.css']
})
export class ReactiveFormsComponent implements OnInit{
  // contactForm = new FormGroup
  // ({
  //   firstname: new FormControl('', [Validators.required,Validators.minLength(5), Validators.maxLength(15), Validators.pattern("^[a-zA-Z]+$")]),
   

  //   // firstname: new FormControl("Rahul"),
  //   // firstname: new FormControl({ value: "Rahul", disabled: true} ),

  //   lastname: new FormControl('', [Validators.required,Validators.minLength(5), Validators.maxLength(15), Validators.pattern("^[a-zA-Z]+$")]),
  //   email: new FormControl(),
  //   gender: new FormControl(),
  //   isMarried: new FormControl(),
  //   country: new FormControl()
  // })
 
  // get firstname() {
  //   return this.contactForm.get('firstname');
  // }
  // get lastname()
  // {
  //   return this.contactForm.get('lastname')
  // }
  // onSubmit() {
  //   console.log("submit");
  //   console.log(this.validateForm.value);
  // }

  validateForm!:FormGroup

  constructor(private fb:FormBuilder){}
  ngOnInit(): void {
    this.validateForm=this.fb.group({
      Pagename:['',Validators.required],
      myUrl:['',[Validators.required,ValidateUrl]]
    });
    
  }


  saveForm(form:FormGroup){
    console.log('Valid: ',form.valid)
    console.log('Pagename: ',form.value.Pagename)
    console.log('myUrl: ',form.value.myUrl)
  }


}
