import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent {
  serverCreateOptions:boolean=false
  serverStatus:string='Offline'
  serverName:string=''
  serverCreated:string='Created'
  serversList=['SQL','ORACLE']
  // ng-Switch
  serverList=['S1','S2','S3','S4','']
  num:number=0
  serverSelected:string=''




constructor(){
    let timeout:number=5000
    setTimeout(() => {
      this.serverCreateOptions=true   
    }, timeout);
  }

AddFn(){
  this.serverStatus='Online'
  this.serversList.push(this.serverName)
}
  onServerName(event:Event){
      return this.serverName=(<HTMLInputElement>event.target).value; //dynamically update the server name     
  }
getColor(){
 return this.serverName=='Online'?'green':'red'
}



}
