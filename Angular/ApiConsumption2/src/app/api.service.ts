import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

private basepath="https://localhost:7126";

  constructor(private http:HttpClient) { }

  public getAllFruitsDetails():Observable<any>
  {
    return this.http.get(this.basepath+"/AdminSide/Fruits")
  }

  public getFruitById(id:number):Observable<any>
  {
    return this.http.get(this.basepath+"/AdminSide/"+id)
  }
  public postItem(prdtlist:any):Observable<any>
  {
    return this.http.post(this.basepath+'/AdminSide/Displaying all Items/',prdtlist)
  }

}
