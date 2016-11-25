PSG.General.BindOpenModal = function (selector, elementSelector) {
    $(document).on('click', selector, function () {
        $('.deletelayershadow, ' + elementSelector + '.modallayer, #divModalLayer').css('display', 'block');
    });
}
PSG.General.BindGameClick = function (selector) {
    $(document).on('click', selector, function () {
        var link = $(this).find('.LinkButton').attr('href');
        window.location.href = link;
    });
}
PSG.General.BindCloseModal = function (selector, elementSelector) {
    $(document).on('click', selector, function () {
        $('#divModalLayer, ' + elementSelector + '.modallayer, .deletelayershadow').css('display', 'none');
    });
};
PSG.General.BindCheckboxClick = function (selector) {
    $(document).on('click', selector, function () {
        if ($(this).children('.checkbox').hasClass('checked')) {
            $(this).children('.checkbox').removeClass('checked');
        } else {
            $(this).children('.checkbox').addClass('checked');
        }
    });
};
//Beim Resizing des Fensters müssen die Menüs angepasst werden
PSG.General.AdaptNavigations = function () {
    $(window).on('resize', function () {
        PSG.General.RefreshMenu();
    });
};
//Regelt das Zusammenlegen der beiden Menüs für die Ansicht auf Geräten mit kleinen Auflösungen durch Umhängen der nötigen Menüpunkte
PSG.General.RefreshMenu = function () {
    if (window.innerWidth < 768) {
        $('.topnavigation .topmenu-item').appendTo('#mainNavbar ul');
        $('.topnavigation .topmenu-account-item').insertAfter('#mainNav .navbar-toggle'); //Login kommt neben den Collapse-Button
        $('.topmenu-item .activetopline').removeClass('activetopline').addClass('topline');
    }
    else { //Die Punkte des Topmenüs, die sich derzeit im Hauptmenü befinden kommen zurück ins Topmenü
        $('#mainNavbar .topmenu-item').appendTo('.topnavigation ul');
        $('#mainNav .topmenu-account-item').appendTo('.topnavigation ul');
        $('.topmenu-item .topline').removeClass('topline').addClass('activetopline');
    }
};