import { Game } from './../game.model';
import { Http } from '@angular/http';
import { serviceGame } from './../serviceGame.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  constructor(private serviceGame:serviceGame,
    private _http:Http 
    ) { }
arrResult:Game[]=[];
found:string="";
  ngOnInit() {
  }
getGame(id, name, p1, p2, win){
  this.arrResult = this.serviceGame.arrResult;
 
this.serviceGame.searchByFilter(id.value, name.value,p1.value, p2.value, win.value);
this.arrResult = this.serviceGame.arrResult;
console.log(this.arrResult);
if (this.arrResult.length===0)
this.found="not found";

//alert(this.arrResult.length);

}
}
