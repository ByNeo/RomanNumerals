var href = 'http://localhost';
var port = '30667';


$(function () {
    romanNumInit();
});



var romanNumInit = function () {
    $('#btnRomanParse').on('click', function () {
        var number = $('#txtNumber').val();

        $('#lblRomanResult').val('');
        romanNumConvert(number);
    });
};

var romanNumConvert = function (number) {

    $.ajax({
        url: href + ':' + port + '/api/RomanNumerals/Converter',
        type: 'GET',
        dataType: 'json',
        data: {
            number: number
        },
        beforeSend: function (xhr) {
            $('#lblRomanResult').text('');
        },
        success: function (data, textStatus, xhr) {
            if (data.IsSuccessful) {
                $('#lblRomanResult').text(data.Data);
            } else {
                alert(data.Message);
            }
        },
        error: function (xhr, textStatus, errorThrown) {
            alert(textStatus + '\n\n' + xhr.responseText);
        }
    });
};