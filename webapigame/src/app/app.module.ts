//import { Observable } from 'rxjs/Observable';

import { RouterModule, Routes } from '@angular/router';


import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';

import { AppComponent } from './app.component';
import {HttpModule} from '@angular/http';
import { serviceGame } from './serviceGame.service';
import { ListGameComponent } from './list-game/list-game.component';
import { SearchComponent } from './search/search.component';

const route:Routes=[
  {path: '', redirectTo: 'list-game' ,pathMatch:'full'},
  {path:'list-game', component:ListGameComponent},
  {path:'app-search', component:SearchComponent}];

@NgModule({
  declarations: [
    AppComponent,
    ListGameComponent,
    SearchComponent
    
    
  ],
  imports: [
    RouterModule.forRoot(route),
    BrowserModule,
    HttpModule
  ],
  providers: [serviceGame],
  bootstrap: [AppComponent]
})
export class AppModule { }
