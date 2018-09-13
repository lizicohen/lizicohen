$(document).ready(function () {
    const url = 'http://localhost:50401/api/game';
    $('#btnAdd').on('click', function () {
        
       
        var item = {
            game_Name: $('#txtName').val(),
            player1: $('#txtPlayer1').val(),
            player2: $('#txtPlayer2').val(),
            who_win: p()
                
        }
        function p() {
            if ($("#rP1").is(":checked"))
                return $('#txtPlayer1').val()
            if ($("#rP2").is(":checked"))
                return $('#txtPlayer2').val()
            else
            return "not know"
            }
       
        var reqAdd = new XMLHttpRequest();
        reqAdd.open('Post', url);
        reqAdd.setRequestHeader("content-Type", "application/json")
        reqAdd.onload = function () {
            console.log("add");
            $('#txtResult').text(reqAdd.response);
        };
        reqAdd.onerror = function () {
            console.log('error');
            alert(reqAdd.response);
        };
        reqAdd.send(JSON.stringify(item));
    });




    ////////////////////////////ajax/////////////////////////////////////////

    $('#btnAddAjax').on('click', function () {
        var item = {
            game_Name: $('#txtName').val(),
            player1: $('#txtPlayer1').val(),
            player2: $('#txtPlayer2').val(),
            who_win: p()

        }
        function p() {
            if ($("#rP1").is(":checked"))
                return $('#txtPlayer1').val()
            if ($("#rP2").is(":checked"))
                return $('#txtPlayer2').val()
            else
                return "not know"
        }
        var ajaxPost = {
            type: "POST",
            url: url,
            contentType: "application/json",
            dataType: "json",
            data: JSON.stringify(item)
        }

        $.ajax(ajaxPost).then(

            function (data) {
                console.log(data)
                alert("game created!")
            }
        ).fail(

            function (err) {
                console.error(err)
            }
        )
    })
});