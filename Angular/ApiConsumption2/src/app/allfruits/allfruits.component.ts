import { Component } from '@angular/core';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-allfruits',
  templateUrl: './allfruits.component.html',
  styleUrls: ['./allfruits.component.css']
})
export class AllfruitsComponent {

  public fruits: any;
  constructor(private service: ApiService) { }

  ngOnInit(): void {
    this.getStudents();
  }

  private getStudents(): void {
    this.service.getAllFruitsDetails().subscribe(result => {
      this.fruits = result;
      console.log(this.fruits);
    });
  }











  selectedquan=0
  final!:number
  // Title
 

  increment(){
     this.final=++this.selectedquan
  }
  decrement()
  {
    this.final=this.selectedquan--
    if(this.selectedquan<0)
      {
        this.selectedquan=0
      }
  }

}
