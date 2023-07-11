import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-getby-id',
  templateUrl: './getby-id.component.html',
  styleUrls: ['./getby-id.component.css']
})
export class GetbyIdComponent implements OnInit{

grp=new FormGroup({
  id: new FormControl('')
})

  prdtlist:any
  
  
  constructor(private api:ApiService){}
  ngOnInit(): void {
    // this.getPrdt()
  }
  public getPrdt():void
  {
    const name:any=this.grp.value.id
    this.api.getFruitById(name).subscribe(res=>{
      this.prdtlist=res
      console.log(this.prdtlist)
    })
  }
}
