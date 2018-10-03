$(document).ready(function () {

    const url = 'http://localhost:50401/api/game';
   
    let ob =  {
                next: (value) => {
                    console.log(value.response)
                    print(value.response)
                },
                error: (err) => console.log(err),
        complete: () => console.log("completed")
            }

    $('#btnOb').on('click', function(){
        Rx.Observable.ajax(url).subscribe(ob)
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