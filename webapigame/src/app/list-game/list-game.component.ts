import { Observable } from 'rxjs';
import { Component, OnInit } from '@angular/core';
import { Game } from './../game.model';
import { serviceGame} from './../serviceGame.service';
import { Router, ActivatedRoute } from '@angular/router';
import {Http} from '@angular/http'


@Component({
  selector: 'app-list-game',
  templateUrl: './list-game.component.html',
  styleUrls: ['./list-game.component.css']
})
export class ListGameComponent implements OnInit {

  arrGame:Game[]=[];
  
 
  constructor(private serviceGame:serviceGame,
                          private _http:Http 
                          
  ) { }
  
  selectedGame:Game;
  
  
  ngOnInit() {
 
  
    this.arrGame = this.serviceGame.arrGame;
    this.serviceGame.getAllGames();
    
   }

   clickRow(i : number)
   {
     console.log(i);
     this.selectedGame=this.arrGame[i];
   }
   addGame( name, p1, p2, win){
    this.serviceGame.postGame(new Game(name.value, p1.value, p2.value, win.value));
      
  console.log("add");
   }
   updateGame(name, p1, p2, win){
    this.serviceGame.putGame(this.selectedGame.ID,new Game(name.value, p1.value, p2.value, win.value));
    console.log("update");
     }

     deleteGame(){
     this.serviceGame.delGame(this.selectedGame.ID);
     console.log(this.selectedGame.ID+" delete");
       }
 }
/* this.serviceGame.getAllGames().subscribe(
  data => { this.gameList = data},
   err => console.error(err),
   () => console.log( this.serviceGame.getAllGames()
 );*/
