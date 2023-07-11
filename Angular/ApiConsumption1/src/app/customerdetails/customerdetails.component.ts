import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Customer } from '../customer';

@Component({
  selector: 'app-customerdetails',
  templateUrl: './customerdetails.component.html',
  styleUrls: ['./customerdetails.component.css']
})
export class CustomerdetailsComponent implements OnInit{

@Input() customer:Customer =new Customer()
@Output() customerChange:EventEmitter<Customer> =new EventEmitter<Customer>(); 
    
constructor() { }
ngOnInit(): void {

}

update() {
  this.customerChange.emit(this.customer);
}

}
