import { Component } from '@angular/core';

@Component({
  selector: 'app-server',
  templateUrl: './server.component.html',
  styleUrls: ['./server.component.css']
})
export class ServerComponent {
serverId:number=1001
serverStatus:string='Offline'
serverNum=[100,101]
getServerId()
{
  return this.serverId
}
getServerStatus(){
  return this.serverStatus
}
constructor(){
  setTimeout(() => {
    this.serverStatus='Online'
  }, 5000);
}

}
