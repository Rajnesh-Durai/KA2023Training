import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllfruitsComponent } from './allfruits/allfruits.component';
import { GetbyIdComponent } from './getby-id/getby-id.component';

const routes: Routes = [
  {path:'',component:AllfruitsComponent},
  {path:'getbyid',component:GetbyIdComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
