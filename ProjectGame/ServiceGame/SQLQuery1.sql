
use GameDB
go
create table Games
(
ID int primary key identity,
Game_Name nvarchar (50),
Player1 nvarchar (50),
Player2 nvarchar (50),
Who_Win nvarchar (50)
)
go
