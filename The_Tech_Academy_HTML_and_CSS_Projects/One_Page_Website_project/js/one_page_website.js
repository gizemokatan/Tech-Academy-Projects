function openModal() {
    /* The slideshow is located in a div which has id "myModal" and class "modal".
    class "modal" CSS style.display is 'none' by default which hides the slideshow from the user,
    which would mean everything in the div will not be displayed. 
    When this function gets called we are setting id "myModal" style.display to block
    to show the slideshow. Essentially, class "modal" gets overridden by id "myModal"
    when this function gets called. */
    document.getElementById("myModal").style.display = "block";
}

function closeModal() {
    // This restores the CSS style.display to 'none', reversing what the above function does.
    // Essentially, the line below causes the slideshow to disappear. 
    document.getElementById("myModal").style.display = "none";
}

var slideIndex = 1;

function plusSlides(n) {
    showSlides(slideIndex += n);
}

function currentSlide(n) {
    showSlides(slideIndex = n);
}

function showSlides(n) {
    var i = 0;
    var slides = document.getElementsByClassName("mySlides");
    var thumbnail = document.getElementsByClassName("image");
    var captionText = document.getElementById("caption");
    // This line makes sure when slides.length goes to 4, it goes to slideIndex 1.
    if (n > slides.length) {slideIndex = 1}
    if (n < 1) {slideIndex = slides.length}
    // This erases all the images from the screen so that we can place the image we want.
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < thumbnail.length; i++) {
        // Thumbnail[i] is the small image currently selected.
        // This code is deactiviting all thumbnails by removing the class that references the CSS to make it appear as active.
        // This process happens for thumbnail index 0, 1 and 2.
        // Thumbnail class name 'image' is sometimes class name 'image active'.
        /* Important: In the first iteration there is no 'image active' class because at the 
        end of this code this class is dynamically being rendered to the HTML. */
        thumbnail[i].className = thumbnail[i].className.replace(" active", ""); 
    }
    // This makes the slide that was selected by the user appear on the screen.
    slides[slideIndex-1].style.display = "block";
    // This concatenates class 'image' with ' active' making it 'image active'
    thumbnail[slideIndex-1].className += " active";
    //document.getElementsByClassName("image")[slideIndex-1].className = className + " active"; 

    // This displays the assigned alternative text based on image position.
    // captionText.innerHTML =  thumbnail[slideIndex-1].alt;
}