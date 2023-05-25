
//Сравнение
        function comparison_function() {
            document.getElementById("comparison-popup").classList.toggle("show_block");
            document.getElementById("comparison-tool").classList.toggle("show_background");
        }

        //О проекте 
        function aboutProject() {
            document.getElementById("new-about-cont").classList.toggle("show_block");
            console.log("fwsfwsf")
        }

        //Закрыть окно О проекте
            $('.about_project_close_button').click(function() {
                document.getElementById("new-about-cont").classList.remove("show_block");
            }
        );

        //Языки
        function language_change() {
            document.getElementById("itsystem-lang-menu").classList.toggle("show_block");
        }

        //Инструменты
        function measurementTools() {
            document.getElementById("itsystem-measure-menu").classList.toggle("show_block");
        }

        //Слои
        $('.itsystem-layers-button').click(function() 
            {
                $(".itsystem-layers-button").css("display", "none");
                $(".itsystem-header.collapsed").css("right", "15px");
                $(".comparison-popup").css("right", "173px");
                $(".layer-switcher-window").css("display", "block");

                $(".comparison-popup").css("right", "168px");
            }
        );

        //Закрыть окно слоёв
        $('.layer-close-button').click(function() 
            {
                $(".layer-switcher-window").css("display", "none");  
                $(".itsystem-header.collapsed").css("right", "82px");
                $(".itsystem-layers-button").css("display", "block");  
                
                $(".comparison-popup").css("right", "235px");
            }
        );
        
        window.onclick = function(event) {
            if (!event.target.matches('.itsystem-curr-lang')) {
                var dropdowns = document.getElementsByClassName("itsystem-lang-menu");
                var i;
                for (i = 0; i < dropdowns.length; i++) {
                    var openDropdown = dropdowns[i];
                    if (openDropdown.classList.contains('show_block')) {
                        openDropdown.classList.remove('show_block');
                    }
                }
            }

            if (!event.target.matches('.itsystem-tool-button')) {
                var dropdowns = document.getElementsByClassName("itsystem-measure-menu");
                var i;
                for (i = 0; i < dropdowns.length; i++) {
                    var openDropdown = dropdowns[i];
                    if (openDropdown.classList.contains('show_block')) {
                        openDropdown.classList.remove('show_block');
                    }
                }
            }
        }