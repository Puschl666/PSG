/*parsed HTML*/
$(function () {
	$(".maxheight").each(function () {
		$(this).contents().wrapAll("<div class='box_inner'></div>");
	})
})
/*add event*/
$(window).bind("resize", height_handler).bind("load", height_handler)
function height_handler() {
    if ($(window).width() > 767) {
        if ($('.maxheight[data-maxheight-group]').length > 0) {
            var groupList = [];
            $(".maxheight").each(function () {
                if (jQuery.inArray($(this).data('maxheightGroup'), groupList) == -1) {
                    groupList.push($(this).data('maxheightGroup'));
                }
            });
            groupList.forEach(function (entry) {
                $('.maxheight[data-maxheight-group="' + entry + '"]').equalHeights();
            });
        } else {
            $(".maxheight").equalHeights();
        }
    } else {
        $(".maxheight").css({ 'height': 'auto' });
        if ($('.maxheight[data-maxheight-group]').length > 0) {
            var groupList = [];
            $(".maxheight").each(function () {
                if (jQuery.inArray($(this).data('maxheightGroup'), groupList) == -1) {
                    groupList.push($(this).data('maxheightGroup'));
                }
            });
            groupList.forEach(function (entry) {
                $('.maxheight.keepInSmall[data-maxheight-group="' + entry + '"]').equalHeights();
            });
        } else {
            $(".maxheight.keepInSmall").equalHeights();
        }
	}
}
/*glob function*/
(function ($) {
	$.fn.equalHeights = function (minHeight, maxHeight) {
		tallest = (minHeight) ? minHeight : 0;
		this.each(function () {
			if ($(">.box_inner", this).outerHeight() > tallest) {
				tallest = $(">.box_inner", this).outerHeight()
			}
		});
		if ((maxHeight) && tallest > maxHeight) tallest = maxHeight;
		return this.each(function () { $(this).height(tallest) })
	}
})(jQuery)