import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule} from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AllfruitsComponent } from './allfruits/allfruits.component';
import { GetbyIdComponent } from './getby-id/getby-id.component';
import { AddfruitComponent } from './addfruit/addfruit.component';
import { UpdatefruitComponent } from './updatefruit/updatefruit.component';
import { DeletefruitComponent } from './deletefruit/deletefruit.component';

@NgModule({
  declarations: [
    AppComponent,
    AllfruitsComponent,
    GetbyIdComponent,
    AddfruitComponent,
    UpdatefruitComponent,
    DeletefruitComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
   HttpClientModule,FormsModule,ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
