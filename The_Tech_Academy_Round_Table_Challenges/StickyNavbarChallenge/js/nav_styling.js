/* reference: https://www.w3schools.com/howto/tryit.asp?filename=tryhow_js_navbar_sticky */


window.onscroll = function() {StickyFunction()};

var navbar = document.getElementById("navbar");
var sticky = navbar.offsetTop;

function StickyFunction() {
    if (window.pageYOffset >= sticky) {
        navbar.classList.add("sticky")
    }
    else {
        navbar.classList.remove("sticky")
    }
}