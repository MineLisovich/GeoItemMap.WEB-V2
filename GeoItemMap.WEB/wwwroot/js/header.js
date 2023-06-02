


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


        //Инструменты
        function measurementTools() {
            document.getElementById("itsystem-measure-menu").classList.toggle("show_block");
        }


        
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

