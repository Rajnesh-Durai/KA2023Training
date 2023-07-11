import { Injectable } from '@angular/core';
import { product } from './product';
import { LoggerService } from './logger.service';
@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private loggerService: LoggerService) {
    this.loggerService.log("Product Service Constructed");
}
  public getProducts() {

 
    this.loggerService.log("getProducts called");

    let products: product[];

    products = [
        new product(1, 'Memory Card', 500),
        new product(1, 'Pen Drive', 750),
        new product(1, 'Power Bank', 100)
    ]

    this.loggerService.log(products);

    return products;
}
  }

