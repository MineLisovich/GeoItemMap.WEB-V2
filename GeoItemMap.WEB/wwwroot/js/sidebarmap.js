


//active accordion and variable width 
(function ($) {
  const accordionItem = $('.sidebarmap-accordion_item');
  const initialWidth = accordionItem.width(); 

  $(".title_block").on("click", function () {
    const currentItem = $(this).parents('.sidebarmap-accordion_item');
    const currentInfo = currentItem.find('.info');
    const isCurrentActive = currentItem.hasClass('active_block'); 

    currentItem.toggleClass('active_block');

    currentItem.css('overflow', 'scroll')
      .siblings('.active_block')
      .removeClass('active_block')
      .children('.info')
      .stop()
      .slideUp({
        duration: 500,
        delay: 100
      });

    currentInfo.stop().slideToggle({
      duration: 500,
      delay: 100
    });

    accordionItem.animate({
      width: isCurrentActive ? initialWidth : initialWidth + 110 + 'px'
    }, {
      duration: 100,
      queue: false
    });

  });
})(jQuery); 


  //multiple-select 
['#small-select2-options-multiple-field', '#small-select2-options-multiple-field_inn', '#small-select2-options-multiple-field_ntp'].forEach(function (selector) {
    $(selector).select2({
        theme: "bootstrap-5",
        width: $(this).data('width') ? $(this).data('width') : $(this).hasClass('w-100') ? '100%' : 'style',
        placeholder: $(this).data('placeholder'),
        closeOnSelect: false,
        selectionCssClass: 'select2--small',
        dropdownCssClass: 'select2--small',
    });
});


['.info_panel-filter', '.info_panel-filter-inn', '.info_panel-filter-ntp'].forEach(function (selector) {
    $(selector).on("change", ".form-select", function () {
    var count = $(this).select2("data").length;
    if (count > 0) {

        $(selector).addClass("filter-name-focus");
    }
    if (count == 0) {
        $(selector).toggleClass("filter-name-focus");
    }
});
});


//filter name
$(".sort-button").click(function () {
     if ($(this).hasClass("actv")) {
       $(this).removeClass("actv").addClass("desc");
        }
        else
        {
            $(this).removeClass("desc").addClass("actv");
        }
});


/*    label at the filter, up, down*/
$(function () {
const $oIcon = $(".o-icon");
const $parksProcessSmall = $(".parks-process-small");
const $closeWindow = $(".close-window");
$oIcon.on('click', function () {
    $parksProcessSmall.removeClass("d-none");
    });
$closeWindow.on('click', function () {
        $parksProcessSmall.toggleClass("d-none");
    });
});


/*sort tehnoparck_ctt*/
$(document).ready(function () {
    var isAscOrder = true;
    $('#sort_tehnoparck_ctt').click(function () {
        var List = $("#info_object_tehnoparck_ctt");
        var ListItem = List.children('a').get();
        ListItem.sort(function (a, b) {
            var compA = $(a).text().toUpperCase();
            var compB = $(b).text().toUpperCase();
            return (isAscOrder ? 1 : -1) * ((compA < compB) ? -1 : (compA > compB) ? 1 : 0);
        });
        isAscOrder = !isAscOrder;
        $.each(ListItem, function (idx, itm) { List.append(itm); });
    });
});


/*sort object_ntp*/
$(document).ready(function () {
    var isAscOrder = true;
    $('#sort_ntp').click(function () {
        var List = $("#info_object_ntp");
        var ListItem = List.children('a').get();
        ListItem.sort(function (a, b) {
            var compA = $(a).text().toUpperCase();
            var compB = $(b).text().toUpperCase();
            return (isAscOrder ? 1 : -1) * ((compA < compB) ? -1 : (compA > compB) ? 1 : 0);
        });
        isAscOrder = !isAscOrder;
        $.each(ListItem, function (idx, itm) { List.append(itm); });
    });
});


/*sort object_inn*/
$(document).ready(function () {
    var isAscOrder = true;
    $('#sort_inn').click(function () {
        var List = $("#info_object_Inn");
        var ListItem = List.children('a').get();
        ListItem.sort(function (a, b) {
            var compA = $(a).text().toUpperCase();
            var compB = $(b).text().toUpperCase();
            return (isAscOrder ? 1 : -1) * ((compA < compB) ? -1 : (compA > compB) ? 1 : 0);
        });
        isAscOrder = !isAscOrder;
        $.each(ListItem, function (idx, itm) { List.append(itm); });
    });
});


$(document).ready(function () {

    $('.window-images a').click(function (e) {
        e.preventDefault();
        var images = [];
        $('.window-images a').each(function () {
            var src = $(this).attr('href');
            var title = $(this).find('img').attr('alt');
            images.push({
                src: src,
                opts: {
                    caption: title
                }
            });
        });

        $.fancybox.open(images, {
            loop: true,
            thumbs: {
                autoStart: true
            }
        });
    });
});