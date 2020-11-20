$(function () {
    var PlaceHolderElement = $('#PlaceHolder');
    $('button[data-toggle="ajax-modal"]').click(function (event) {

        var url = $(this).data('url');
        var decodedUrl = decodeURIComponent(url)
        $.get(decodedUrl).done(function (data) {
            PlaceHolderElement.html(data);

            PlaceHolderElement.find('.modal').modal('show');
        })
    })
    PlaceHolderElement.on('click', '[data-save="modal"]', function (event) {

        var form = $(this).parents('.modal').find('form');
     
        var actionURL = form.attr('action');
        var sendData = form.serialize();
        $.post(actionURL, sendData).done(function (data) {
                PlaceHolderElement.html(data);
                PlaceHolderElement.find('.modal').modal('show');
        })
    })
})