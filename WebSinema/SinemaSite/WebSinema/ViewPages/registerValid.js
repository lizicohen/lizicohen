function validationReg() {

    if ($('#txtNewPassword').val() === $('#txtConfirmPassword').val()) {
        validArr[0] = true;
        alert("match")
        return true;
    } else
        validArr[0] = false;
    alert("the password not match");
    return false;

   // alert("try");
    for (x of validArr) {
        if (x === false) {
            return false;
        }
    }
    return true;
}
var validArr = [false, false, false, false];

    $('#txtConfirmPassword').on('leave', function () {
        if ($('#txtNewPassword').val() === $('#txtConfirmPassword').val()) {
            validArr[0] = true;
            alert("match")
            return true;
        } else
            validArr[0] = false;
        alert("the password not match");
        return false;
  //  });
//$('#txtCvv').on('submit', function () {
    if ($('#txtCvv').val().length!==3){
        alert("length cvv is 3 digit");
        validArr[1] = false
        return false;
    } else
        validArr[1] = true;
    return true;
//});
$('#txtNewExpirty').on('submit', function () {
    var date = new Date($('#txtNewExpirty').val()).getTime();
    var presentDate = new Date().getTime();
    if (!date > presentDate) 
    {
        alert("Date Expirty passed!");
        validArr[2] = false
        return false;
    } else
        validArr[2] = true;
    return true;
});
$('#txtNewNumCard').on('submit', function () {
    if (($('#txtNewNumCard').val().length === 8) || ($('#txtNewNumCard').val().length === 16) || ($('#txtNewNumCard').val().length === 14) || ($('#txtNewNumCard').val().length === 15)) {
        validArr[3] = true;
        return true;
    } else
        alert("number credit card is error!")
    validArr[3] = false;
    return false;
});

