// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

//var header = document.getElementById("myDIV");
//var btns = header.getElementsByClassName("btn");
//for (var i = 0; i < btns.length; i++) {
//    btns[i].addEventListener("click", function () {
//        document.getElementById("home").className.replace("active", "notactive");
//        var current = document.getElementsByClassName(" active");
//        current[0].className = current[0].className.replace(" active", "");
//        this.className += " active";
//    });
//}
$(document).ready(function () {

    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
    });

});
function checkit() {
    var name = document.getElementById("uname").value;
    alert("This worked " + name);
    localStorage.setItem("lastname", name);
    document.getElementById("result").innerHTML = localStorage.getItem("lastname");
    
    document.getElementById("signup").style.visibility = "hidden";

}
document.getElementById("result").innerHTML = localStorage.getItem("lastname");

$(document).ready(function () {
    $(".btn1").click(function () {
        $("#signup").toggle();
    });
});

