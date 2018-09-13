$(document).ready(function () {
    const url = 'http://localhost:50401/api/game';
 
    $('#btnGet').on('click', function () {
        var id = $('#txtId').val()
        var reqId = new XMLHttpRequest();
        reqId.open('Get', url + "/" + id);
        
        reqId.onload = function () {
            console.log("id");
            var data = JSON.parse(reqId.response)
            
            //$('#txtName').text(data.Game_Name)
            document.getElementById("txtPlayer1").value = data.Player1
            document.getElementById("txtPlayer2").value = data.Player2
            document.getElementById("txtName").value = data.Game_Name
         //   $('#txtPlayer1').text( data.Player1)// not work
          //  $('#txtPlayer2').text( data.Player2)
            if (data.who_win === data.Player1)
                $('#rP1').prop('checked', true)
           
            if (data.who_win === data.player2)
                $('#rP2').prop('checked', true)
        };
        reqId.onerror = function () {
            console.log('error');
           
        };
        reqId.send();
    });

    $('#btnPut').on('click', function () {

        var id = $('#txtId').val()
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

        var reqPut = new XMLHttpRequest();
        reqPut.open('Put', url+"/"+id);
        reqPut.setRequestHeader("content-Type", "application/json")
        reqPut.onload = function () {
            console.log("put");
            alert(reqPut.response);
        };
        reqPut.onerror = function () {
            console.log('error');
            alert(reqPut.response);
        };
        reqPut.send(JSON.stringify(item));
    });

    $('#btnDelete').on('click', function () {
        var id = $('#txtId').val()
        var reqDel = new XMLHttpRequest();
        reqDel.open('Delete', url + "/" + id);

        reqDel.onload = function () {
            console.log("id");
            
            alert("delete")
            
        };
        reqDel.onerror = function () {
            console.log('error');

        };
        reqDel.send();
    });


    //////////////////////////////////////////ajax///////////////////////////////////////////
    $('#btnIdAjax').on('click', function () {
        var id = $("#txtId").val()
        $.ajax({
            url: url + "/" + id

        }).then(
            function (data) {
                document.getElementById("txtPlayer1").value = data.Player1
                document.getElementById("txtPlayer2").value = data.Player2
                document.getElementById("txtName").value = data.Game_Name 
                if (data.who_win === data.Player1)
                    $('#rP1').prop('checked', true)
             
                if (data.who_win === data.player2)
                    $('#rP2').prop('checked', true)
            }
        ).fail(
            function (err) {
                
                console.log(err)
                alert("not found id")
            }
        )

        $('#btnPutAjax').on('click', function () {
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
            var ajaxPut = {
                type: "PUT",
                url: url +"/"+id,
                contentType: "application/json",
                dataType: "json",
                data: JSON.stringify(item)
            }

            $.ajax(ajaxPut).then(

                function (data) {
                    console.log(data)
                    alert("game update!")
                }
            ).fail(

                function (err) {
                    console.error(err)
                }
            )
        })


    })

    $('#btnDeleteAjax').on('click', function () {
        var id = $("#txtId").val()
        var ajaxDelete = {
            type: "DELETE",
            url: url + "/" + id,
            contentType: "application/json",
            dataType: "json",

        }

        $.ajax(ajaxDelete).then(
            function () {
                alert("game delete!")
            }).fail(
                function (err) {
                    console.error(err)
                }
            )
    })
});