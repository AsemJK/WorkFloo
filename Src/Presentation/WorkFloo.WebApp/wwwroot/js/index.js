$(function () {
    $.getJSON('api/v1/Doc/GetErrorCodes', function (data) {
        $.each(data, function (key, val) {
            $('<option>').text(val).appendTo($('#errorCodes'));
        });
    });
});