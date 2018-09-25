
export class Game{     
    private static gameId: number = 0;
    public ID: number = ++Game.gameId; 
     
    constructor( public Game_Name:string,public Player1:string ,public Player2:string, public Who_Win:string) {
     
    }
}
