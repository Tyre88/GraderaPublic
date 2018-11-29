$(window).load(function () {
    $('#slider').nivoSlider({
        effect: 'random',
        slices: 15,
        animSpeed: 700,
        pauseTime: 2500,
        startSlide: 0, //Set starting Slide (0 index)
        directionNav: false,
        directionNavHide: false, //Only show on hover
        controlNav: false, //1,2,3...
        controlNavThumbs: false, //Use thumbnails for Control Nav
        pauseOnHover: true, //Stop animation while hovering
        manualAdvance: false, //Force manual transitions
        captionOpacity: 0.6, //Universal caption opacity
        beforeChange: function () { },
        afterChange: function () { },
        slideshowEnd: function () { } //Triggers after all slides have been shown
    });
});


function sendFeedback() {
    $('#valid').slideUp('fast');
    $.post("../../Home/SendFeedback/", getFeedbackData(), function (data) {
        if (data == "ok") {
            $('#valid').html("<p style='color: Green'>Tack för ditt meddelande</p>");
            $('#valid').slideDown('slow');
            setTimeout(function () {
                closeFeedback();
                $('#name').val("");
                $('#email').val("");
                $('#subject').val("");
                $('#text').val("");
            }, 4000);
        }
        else {
            $('#valid').html(data);
            $('#valid').slideDown('slow');
        }
    })
}

function getFeedbackData() {
    var name = $('#name').val();
    var email = $('#email').val();
    var subject = $('#subject').val();
    var text = $('#text').val();

    return { Name: name, Email: email, Subject: subject, Text: text };
}

function showFeedback() {
    $('#feedback').slideDown('slow', function () {
    });
    $('#fader').fadeIn('slow', function () {
    });
}

function showSwish() {
    $('#swish').slideDown('slow', function () { });
    $('#fader').fadeIn('slow', function () { });
}

function closeSwish() {
    $('#swish').slideUp('slow', function () {
    });
    $('#fader').fadeOut('slow', function () {
    });
}

function closeFeedback() {
    $('#feedback').slideUp('slow', function () {
    });
    $('#fader').fadeOut('slow', function () {
    });
}