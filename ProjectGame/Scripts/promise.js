class WebAPIClient {

    constructor(mock) {
        this.mock = mock
    }

   

         emptyPromise() {
             if (this.mock) {
                 var promise = $.ajax({
                     url: 'http://localhost:50401/api/game'
                 })
                 return promis
             } 
                 var p = new Promise(function (resolve) {
                     var _game = []
                     resolve(_game)

                 })
                 return p
             
        }
        testPromise() {
            if (this.mock) {
                var promise = $.ajax({
                    url: 'http://localhost:50401/api/game'
                })
                console.log(promise)
                return promis;
            }
                var p = new Promise(function (resolve) {
                    var _game = [
                        new Game(1, "taki", "Tal", "Gal", "Tal"),
                        new Game(2, "taki", "Tal", "Gal", "Tal"),
                        new Game(3, "taki", "Tal", "Gal", "Tal"),
                        new Game(4, "taki", "Tal", "Gal", "Tal"),
                        new Game(5, "taki", "Tal", "Gal", "Tal"),
                        new Game(6, "taki", "Tal", "Gal", "Tal"),
                        new Game(7, "taki", "Tal", "Gal", "Tal"),
                        new Game(8, "taki", "Tal", "Gal", "Tal")
                    ]
                    resolve(_game)

                })
                return p
            
        }

        errorPromise() {
            if (this.mock) {
                var promise = $.ajax({
                    url: 'http://localhost:50401/api/game'
                })
                return promis
            }
                var p = new Promise(function ( reject) {

                    reject("not found")
                })
                return p
            
        }
}
function pro() {

    let prom = new WindowAPi();
    return prom.getMock();

}

$('#btnPro').on('click', function () {
    alert("mock")
    let myMock = new WebAPIClient(false)
    myMock.then(
        function (data) {
            print(data)
        }
    ).fail(
        function (err) {
            console.log(err)
        })
})


function print(data) {
   
    for (var i = 0; i < data.length; i++) {
        var item = data[i];
        for (var field in item) {
            $('#txtResult').append(" " + field +
                " : " + item[field] + ", ")
        }
        $('#txtResult').append("<br>")
    }

}

function Game(Id, Game_Name, Player1, Player2, Who_Win)
    
    {
        this.Id = Id;
        this.Game_Name = Game_Name;
        this.Player1 = Player1;
        this.Player2 = Player2;
        this.Who_Win = Who_Win
    }


function WindowAPi() {

    this.g = {}
    this.getMock = function () {

        var mock = new WebAPIClient(false)


        var promiseResult = mock.testPromise();//or errorPromise or emptyPromise()

        promiseResult.then(
            (data) => {

                this.g = data
                console.log(data)
                if (data.constructor === Array ) {
                    print(data)
                    if (data.length == 0)
                        $('#txtResult').text("not games");
                }
                   
                else
                    $('#txtResult').text(data);
                
            },
            (err) => {
                console.error(err)
            }
        )
    }
}