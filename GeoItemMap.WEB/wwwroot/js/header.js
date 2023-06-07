$(document).ready(function () {
    // О проекте (открыть модальное окно)
    const $aboutProject_open = $("#aboutProject_open");
    $aboutProject_open.click(function () {
        $("#new-about-cont").addClass("show_block");
    });
    // О проекте (закрыть модальное окно)
    const aboutProject_close = $("#aboutProject_close");
    aboutProject_close.click(function () {
        $("#new-about-cont").removeClass("show_block");
    });
});
       
      

