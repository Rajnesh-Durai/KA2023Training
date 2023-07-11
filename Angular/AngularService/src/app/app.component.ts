import { Component } from '@angular/core';
import { ProductService } from './product.service';
import { product } from './product';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Service';
  products!: product[];
  // productService;

  // constructor(){
  //   this.productService=new ProductService();
  // }

  constructor(private productService:ProductService) {    
 
  }    

  getProductsfromService() {
    
    this.products=this.productService.getProducts();
  }
}
