import { serviceGame } from './serviceGame.service';
import { Component } from '@angular/core';
import {Http} from '@angular/http'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
  
})
export class AppComponent {
  constructor(private _http:Http, private _serviceGame : serviceGame
  ) {}
    
  title = 'app';
  
}
