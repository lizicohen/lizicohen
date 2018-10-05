import { Observable } from 'rxjs';
//import { Observable } from 'rxjs/Observable';
import { Game } from './game.model';

import { Injectable} from '@angular/core';

import { EventEmitter } from '@angular/core';
import {Http} from '@angular/http'
import { URLSearchParams } from 'url';
//import { forEach } from '@angular/router/src/utils/collection';

@Injectable()
export class serviceGame{
   
    arrGame:Game[] = [];
    arrResult:Game[]=[];
    constructor(private _http:Http) {
       // this.url='http://localhost:50401/api/game';
       
    }
    url='http://localhost:50401/api/game';
    
 
    
    getAllGames(){
        this.arrGame.length=0;
        return this._http.get(this.url).subscribe(
        (res=>{
            console.log(res);
            var data = res.json();
            
            for(let i of data )
            {
                console.log(i)
                this.arrGame.push(i)
            }
            

        }));
        
    }
    postGame(game){
        return this._http.post(this.url,game).subscribe(
             (response=>{
                console.log(response.status)
                if(response.status >=200 && response.status< 300)
                alert("the game added")
                else
                alert(response.statusText);
            }
        ));
    }
    putGame(id,game){
        return this._http.put(this.url+"/"+id, game).subscribe(
            (response=>{
                console.log(response.status)
                if(response.status >=200 && response.status< 300)
                alert("the game update")
                else
                alert(response.statusText);
            }
        ));
    }
    delGame(id){
        return this._http.delete(this.url+"/"+ id).subscribe(
            (response=>{
                console.log(response.status)
                if(response.status >=200 && response.status< 300)
                alert("the game delete")
                else
                alert(response.statusText);
            }
        ));
    }
  
searchByFilter(id,name, player1, player2, who_win){
    
    let param=[id,name, player1, player2, who_win]
    let serachUrl ="http://localhost:50401/api/game/SearchFilter?";
    
    id!=0?serachUrl+="id="+id+"&":true;
    name!=""?serachUrl+="name="+name+"&":true;
    player1!=""?serachUrl+="player1="+player1+"&":true;
    player2!=""?serachUrl+="player2="+player2+"&":true;
    who_win!=""?serachUrl+="who_win="+who_win+"&":true;
    serachUrl = serachUrl.substring(0,serachUrl.length-1);
   // alert(serachUrl);
    while (this.arrResult.length > 0)
   {
       this.arrResult.pop();
   }
   
    return this._http.get(serachUrl).subscribe(
        (response=>{
            console.log(response);
            var temp = response.json();
            for(let item of temp)
            {
                console.log(item)
                 this.arrResult.push(item)
            }
            
            
        }));
        
}
}

