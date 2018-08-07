jQuery(document).ready(function ($) {
    $(window).scroll(function () {
        if ($(this).scrollTop() > 50) {
            $('#backToTop').fadeIn('slow');
        } else {
            $('#backToTop').fadeOut('slow');
        }
    });
    $('#backToTop').click(function () {
        $("html, body").scrollTop(0);
        return false;
    });
});