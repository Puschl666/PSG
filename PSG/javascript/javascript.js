// Agency Theme JavaScript

(function ($) {
    "use strict"; // Start of use strict

    // jQuery for page scrolling feature - requires jQuery Easing plugin
    $('a.page-scroll').bind('click', function (event) {
        var $anchor = $(this);
        $('html, body').stop().animate({
            scrollTop: ($($anchor.attr('href')).offset().top - 50)
        }, 1250, 'easeInOutExpo');
        event.preventDefault();
    });

    // Highlight the top nav as scrolling occurs
    $('body').scrollspy({
        target: '.navbar-fixed-top',
        offset: 51
    });

    // Closes the Responsive Menu on Menu Item Click
    $('.navbar-collapse ul li a:not(.dropdown-toggle)').click(function () {
        $('.navbar-toggle:visible').click();
    });
})(jQuery); // End of use strict

$(document).ready(function () {
	// Offset for Main Navigation
	$('#mainNav').affix({
		offset: {
			top: 100
		}
	})

	PSG.General.RefreshMenu(); //Men�s initialisieren
	PSG.General.AdaptNavigations(); //Beide Men�s beim Resizing f�r Responsive-Gestaltung zusammenlegen

});