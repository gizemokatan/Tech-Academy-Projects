/* reference: https://www.w3schools.com/howto/tryit.asp?filename=tryhow_js_navbar_sticky */

/* the function will be called as soon as the user scrolls on the page */
window.onscroll = function() {StickyFunction()};

var navbar = document.getElementById("navbar");
/* offsetTop returns a number of pixels from the top of the closest relatively positioned parent element (in this case the body element). */
var sticky = navbar.offsetTop;

function StickyFunction() {
    /* if the page reaches a height on the Y axis (pixels) that is greater than or equal to the number of pixels in the sticky variable, */
    if (window.pageYOffset >= sticky) {
        /* add a class called 'sticky' to the navbar element */
        navbar.classList.add("sticky")
    }
    else {
        /* otherwise, remove the class called 'sticky' */
        navbar.classList.remove("sticky")
    }
}