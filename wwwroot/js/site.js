// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function onlyNumberWithDecimal(event, element) {
    $(element).val($(element).val().replace('.', ','));
    $(element).val($(element).val().replace(/[^0-9\,.]/g, ''));
    if ((event.which != 44 || $(element).val().indexOf(',') != -1) &&
        (event.which != 46 || $(element).val().indexOf(',') != -1) &&
        (event.which < 48 || event.which > 57)) {

        event.preventDefault();
    }
    
}

function onlyNumberWithoutDecimal(event, element) {
    $(element).val($(element).val().replace(/[^\d].+/, ""));
    if ((event.which < 48 || event.which > 57)) {
        event.preventDefault();
    }
}

