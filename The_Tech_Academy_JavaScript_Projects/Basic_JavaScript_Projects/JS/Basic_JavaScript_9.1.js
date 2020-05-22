var slideIndex = 1; 
showSlides(slideIndex);

// Next/previous controls

//when you click next arrow it adds one to the current slideIndex
//when you click prev arrow it subtracts one from the current slideIndex
function plusSlides(n) {
    // showSlides(slideIndex = slideIndex + n); same as code below
    showSlides(slideIndex += n);
}

// Thumbnail image controls

/* each dot has a specific number, number 1, 2, and 3 and
when you click on a specific dot, it retrieves a specific value, which gets assigned to 
slideIndex. That reassigned value gets passed into showSlides which is being called*/
function currentSlide(n) {
    showSlides(slideIndex = n);
}

function showSlides(n) {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");
    
    //if the slide length is ever 4, make slideIndex 1
    if (n > slides.length) {slideIndex = 1}

    //if the slideIndex is ever 0, make slideIndex be 3, (the amount of slides)
    if (n < 1) {slideIndex = slides.length}

    //remove each image, setting the display to none regardless of the image
    //the reason its in a for loop is because it wants to make sure there is no image before preceeding with the code
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }

    //each dot is deactivated due to replacing the class name with "" (points it to a class that doesnt exist)
    //it makes sure that the active class is not used in css (removes the dark grey color)
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }

    //it changes the css from 'none' to 'block' display to display an img
    /*slideIndex number is calculated depending whether the user clicks next or previous buttons
    which would add or subtract the number respectively. The calculated number minus one will
    give the index of the next img or prev img in the slideshow*/
    slides[slideIndex-1].style.display = "block";

    //it changes the css from "" to " active" display to reference the active class in the css
    //the active class changes the dot to a dark grey color
    /*slideIndex number is calculated depending whether the user clicks next or previous buttons
    which would add or subtract the number respectively. The calculated number minus one will
    give the index of the next dot or prev dot of the slideshow*/
    dots[slideIndex-1].className += " active";
}
