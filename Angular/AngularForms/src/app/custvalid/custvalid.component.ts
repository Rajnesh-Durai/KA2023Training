import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { gte } from './gte.validator';
import { namecheck } from './namecheck.validator';

@Component({
  selector: 'app-custvalid',
  templateUrl: './custvalid.component.html',
  styleUrls: ['./custvalid.component.css']
})
export class CustvalidComponent {
  myForm = new FormGroup({
    numVal : new FormControl('', [gte]),
    nameVal : new FormControl('', [namecheck]),
  })
 
  get numVal() {
    return this.myForm?.get('numVal');
  }
  get nameVal() {
    return this.myForm?.get('nameVal');
  }
 
  onSubmit() {
    console.log(this.myForm.value);
}

}
