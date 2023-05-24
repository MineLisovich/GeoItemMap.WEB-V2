// active accordion and variable width 
(function ($) {
  const accordionItem = $('.sidebarmap-accordion_item');
  const initialWidth = accordionItem.width(); 

  $(".title_block").on("click", function () {
    const currentItem = $(this).parents('.sidebarmap-accordion_item');
    const currentInfo = currentItem.find('.info');
    const isCurrentActive = currentItem.hasClass('active_block'); 

    currentItem.toggleClass('active_block');

    currentItem.css('overflow', 'hidden')
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
      width: isCurrentActive ? initialWidth : initialWidth + 80 + 'px'
    }, {
      duration: 100,
      queue: false
    });
  });
})(jQuery); 

// window 

$(document).ready(function () {
const $btnToggle = $(".info_item-data");
const $closeWindow = $(".close-window");
const $windowbar = $(".window");
const $windowChild = $(".window-child");
$btnToggle.click(function () {
$windowbar.toggleClass("active");
$windowChild.toggleClass("active");
});
$closeWindow.click(function () {
$windowbar.removeClass("active");
$windowChild.removeClass("active");
});
const $btnToggleChild = $(".info_item-data");
const $closeBtn = $(".window-side-button");
$btnToggleChild.click(function () {
$windowChild.addClass("active");
});
$closeBtn.click(function () {
$windowChild.removeClass("active");
});
});

// window-button 

$(document).ready(function () {
  const $buttonLeft = $(".window-side-button_left");
  const $childContainer = $(".window-child-container")
  const $closeBtn = $(".window-side-button");
  const $windowChild = $(".window-child");

  $buttonLeft.click(function () {
    $windowChild.animate({
      width: 0
    }, 200);
    $buttonLeft.hide();
    $childContainer.hide();
  });

  $closeBtn.click(function () {
    $windowChild.toggleClass("active");
    $windowChild.animate({
      width: 300
    }, 250);
    $buttonLeft.show();
    $childContainer.show();
  });
});

//anchors window
document.addEventListener("DOMContentLoaded", function () {
  var listItems = document.querySelectorAll("ol li[data-link], ol li ol li[data-link]");
  listItems.forEach(function (listItem) {
    var linkValue = listItem.getAttribute("data-link");
    var targetElement = document.getElementById(linkValue);
    if (targetElement) {
      listItem.addEventListener("click", function (e) {
        e.stopPropagation(); // останавливаю всплытие события 
        targetElement.scrollIntoView({
          behavior: "smooth"
        });
      });
    }
  });
});

// active element on click li

document.querySelectorAll("ol li > div").forEach(div => {
  div.addEventListener("click", function (e) {
    document.querySelectorAll(".active-li").forEach(active => {
      active.classList.remove("active-li");
    });
    this.classList.add("active-li");
  });
});


// modal window for the gallery

function openModal() {
    document.getElementById("modal-gallery").style.display = "block";
    showSlides(slideIndex); // Показать первый слайд при открытии модального окна
  }

  function closeModal() {
    document.getElementById("modal-gallery").style.display = "none";
  }

  var slideIndex = 1;
  showSlides(slideIndex);

  function plusSlides(n) {
    showSlides(slideIndex += n);
  }

  function currentSlide(n) {
    showSlides(slideIndex = n);
  }

  function showSlides(n) {
    var i;
    var slides = document.getElementsByClassName("slides-gallery");
    var dots = document.getElementsByClassName("demo");
    var captionText = document.getElementById("caption");
    if (n > slides.length) {
      slideIndex = 1;
    }
    if (n < 1) {
      slideIndex = slides.length;
    }
    for (i = 0; i < slides.length; i++) {
      slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
      dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
    captionText.innerHTML = dots[slideIndex - 1].alt;
  }