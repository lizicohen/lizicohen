const url = 'http://localhost:50401/api/game';
$(document).ready(function () {
    
    var search = txtSearch.value;
    $('#btnAll').on('click', function () {
        var reqAll = new XMLHttpRequest();
        reqAll.open('Get', url);
        reqAll.onload = function () {
            console.log("all");
            $('#txtResult').text(reqAll.response);
        };
        reqAll.onerror = function () {
            console.log('error');
            alert(reqAll.response);
        };
        reqAll.send();
    });

    $('#btnByWin').on('click', function () {
        var search = txtSearch.value;
        var reqWin = new XMLHttpRequest();
        reqWin.open('Get', url + "/GetByWiner/" + search);
        reqWin.onload = function () {
            console.log("win");
            $('#txtResult').text(reqWin.response);

        };
        reqWin.onerror = function () {
            console.log('error');
            alert(reqWin.response);
        };
        reqWin.send();
    });

    $('#btnId').on('click', function () {
        var search = txtSearch.value;
        var reqId = new XMLHttpRequest();
        reqId.open('Get', url + "/" + search);
       
        reqId.onload = function () {
            console.log("id");
            $('#txtResult').text(reqId.response);
        };
        reqId.onerror = function () {
            console.log('error');
           
        };
        reqId.send();
    });

    $('#btnName').on('click', function () {
        var search = txtSearch.value;
        var reqName = new XMLHttpRequest();
        reqName.open('Get', url + "/GetByName/" + search);
        reqName.onload = function () {
            console.log("name");
            $('#txtResult').text(reqName.response);
        };
        reqName.onerror = function () {
            console.log('error');
            alert(reqName.response);
        };
        reqName.send();
    });




    /////////////////////////////////////////////////////////ajax/////////////////////////////////////////////////
    $('#btnGetAjax').on('click', function () {
        $.ajax({
            url: url
        }).then(
            function (data) {
             print(data)             
            }
        ).fail(
            function (err) {
                console.log(err)
            })
    })


    $('#btnIdAjax').on('click', function () {
        var id = $("#txtSearch").val()
        $.ajax({
            url: url + "/" + id
           
        }).then(
            function (data) {
                console.log(data)
                for (var field in data) {
                    $('#txtResult').append(" " + field +
                        " : " + data[field] + ", ")
                }
            }
        ).fail(
            function (err) {0
                console.log(err)
                alert("not found id")
            }
            )
    })

    $('#btnWinAjax').on('click', function () {
        var win = $("#txtSearch").val()
        $.ajax({
            url: url + "/GetByWiner/" + win
        }).then(

            function (data) {
              print(data)
            }
        ).fail(
            function (err) {
                console.log(err)
            }
        )
    })

    $('#btnNameAjax').on('click', function () {
        var name = $("#txtSearch").val()
        $.ajax({
            url: url + "/GetByName/" + name
        }).then(

            function (data) {
                print(data)
            }
        ).fail(
            function (err) {
                console.log(err)
            }
        )
    })


});
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



