
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
$('#small-select2-options-multiple-field').select2({
    theme: "bootstrap-5",
    width: $(this).data('width') ? $(this).data('width') : $(this).hasClass('w-100') ? '100%' : 'style',
    placeholder: $(this).data('placeholder'),
    closeOnSelect: false,
    selectionCssClass: 'select2--small',
    dropdownCssClass: 'select2--small',
});
$('#small-select2-options-multiple-field_inn').select2({
    theme: "bootstrap-5",
    width: $(this).data('width') ? $(this).data('width') : $(this).hasClass('w-100') ? '100%' : 'style',
    placeholder: $(this).data('placeholder'),
    closeOnSelect: false,
    selectionCssClass: 'select2--small',
    dropdownCssClass: 'select2--small',
});
$('#small-select2-options-multiple-field_ntp').select2({
    theme: "bootstrap-5",
    width: $(this).data('width') ? $(this).data('width') : $(this).hasClass('w-100') ? '100%' : 'style',
    placeholder: $(this).data('placeholder'),
    closeOnSelect: false,
    selectionCssClass: 'select2--small',
    dropdownCssClass: 'select2--small',
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



$(function (e) {
    const $d = $(".info_panel-filter");
    $d.on('click', function () {
        $d.addClass("filter-name-focus");
    });

});




//$(document).ready(function () {
//    $select = $(".select2-selection");
//    $filterName = $(".filter-name");
//    $textarea = $(".select2-search__field");
//    $select.click(function () {
//        $(this).removeClass("color");
//        $filterName.addClass("color");
        
       
//    });
//});





//СЛАЙДЕР НАЧАЛО

//modal window for the gallery
//function openModal() {
//    document.getElementById("modal-gallery").style.display = "block";
//    showSlides(slideIndex); // Показать первый слайд при открытии модального окна
//}

//function closeModal() {
//    document.getElementById("modal-gallery").style.display = "none";
//}

//var slideIndex = 1;
//showSlides(slideIndex);

//function plusSlides(n) {
//    showSlides(slideIndex += n);
//}

//function currentSlide(n) {
//    showSlides(slideIndex = n);
//}

//function showSlides(n) {
//    var i;
//    var slides = document.getElementsByClassName("slides-gallery");
//    var dots = document.getElementsByClassName("demo");
//    var captionText = document.getElementById("caption");
//    if (n > slides.length) {
//        slideIndex = 1;
//    }
//    if (n < 1) {
//        slideIndex = slides.length;
//    }
//    for (i = 0; i < slides.length; i++) {
//        slides[i].style.display = "none";
//    }
//    for (i = 0; i < dots.length; i++) {
//        dots[i].className = dots[i].className.replace(" active", "");
//    }
//    slides[slideIndex - 1].style.display = "block";
//    dots[slideIndex - 1].className += " active";
//    captionText.innerHTML = dots[slideIndex - 1].alt;
//}
// СЛАЙДЕР КОНЕЦ