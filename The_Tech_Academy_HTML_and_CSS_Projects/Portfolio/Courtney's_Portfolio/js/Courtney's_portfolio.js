// These functions open and close the contact form 
function openForm() {
    document.getElementById("myForm").style.display = "block";
  }
  
  function closeForm() {
    document.getElementById("myForm").style.display = "none";
  }

// Added jQuery to slideshow
$("#slideshow2 > div:gt(0)").hide();

setInterval(function() {
    $('#slideshow2 > div:first')
    .fadeOut(1000)
    .next()
    .fadeIn(1000)
    .end()
    .appendTo('#slideshow2');
}, 3000);
  