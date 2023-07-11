import { Component } from '@angular/core';

@Component({
  selector: 'app-template-forms',
  templateUrl: './template-forms.component.html',
  styleUrls: ['./template-forms.component.css']
})
export class TemplateFormsComponent {
  countryList:country[]=[
    new country('1','India'),
    new country('2','Australia'),
    new country('3','New Zealand')
  ];
  // for [(ngModule)]
  contact! : contact;
  constructor() {
    this.contact = {
      firstname: "Sachin",
      lastname: "Tendulkar",
      email: "sachin@gmail.com",
      gender: "male",
      isMarried: true,
      country: "2",
      address: { city: "Mumbai", street: "Perry Cross Rd", pincode: "400050" }
    };

  }

  onSubmit(contactForm:any){
    console.log(this.contact)
  }

  // setDefaults(){
  //   this.contact = {
  //     firstname: "Sachin",
  //     lastname: "Tendulkar",
  //     email: "sachin@gmail.com",
  //     gender: "male",
  //     isMarried: true,
  //     country: "2",
  //     address: { city: "Mumbai", street: "Perry Cross Rd", pincode: "400050" }
  //   };
  // }


  reset(contactForm :any) {
    contactForm.resetForm();

}
}
export class contact {
  firstname: string = '';
  lastname: string = '';
  email: string = '';
  gender: string = '';
  isMarried: boolean = false;
  country: string = '1';
  address!: {
    city: string;
    street: string;
    pincode: string;
  }; 
}

export class country{
  id:string
  name:string

  constructor(id:string,name:string){
    this.id=id
    this.name=name
  }
}

