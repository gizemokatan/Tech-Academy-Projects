//switch statment; a type of conditional statement

function flavorFunction() {
    var flavor_output;
    var flavors = document.getElementById("flavor_input").value;
    var flavor_str = " is a great ice cream flavor!";
    switch(flavors) {

    //Each case will be evaluated based on user input
        case "Chocolate":
            flavor_output = "Chocolate" + flavor_str;
        break;
        case "Vanilla":
            flavor_output = "Vanilla" + flavor_str;
        break;
        case "Strawberry":
            flavor_output = "Strawberry" + flavor_str;
        break;
        case "Mint Chip":
            flavor_output = "Mint Chip" + flavor_str;
        break;
        case "Bananas Foster":
            flavor_output = "Bananas Foster" + flavor_str;
        break;
        case "Cookies and Cream":
            flavor_output = "Cookies and Cream" + flavor_str;
        break;

    /*default keyword will prompt a user to enter an item 
    exactly as written from the list if the entry doesn't match a case */
        default:
            flavor_output = "Please enter a flavor exactly as written on the above list.";
    }
    document.getElementById("output").innerHTML = flavor_output;
}

//get elements by class name
function HWfunction() {
    var a = document.getElementsByClassName("click");
    a[0].innerHTML = "It's not magic!";
}

//drawing graphics with canvas tag

var c = document.getElementById("myCanvas");

/* The getContext() method returns an object that provides 
methods and properties for drawing on the canvas.
Its simpler to define it in a variable. */
var ctx = c.getContext("2d");

ctx.font = "20px Georgia";

//parameters for fillText are (text, x, y)
ctx.fillText("Hello World!", 10, 50);

ctx.font = "30px Veranda";
//Create gradient
var gradient = ctx.createLinearGradient(0, 0, c.width, 0);

/*parameters for addColorStop are (stop, color), where stop is
a value between 0.0 and 1.0 that represents the position between
start and end in a gradient.*/
gradient.addColorStop("0", "magenta");
gradient.addColorStop("0.5", "blue");
gradient.addColorStop("1.0", "green");
//Fill with gradient
ctx.fillStyle = gradient;
ctx.fillText("I made this with JavaScript!", 10, 90);

// //create background gradient left to right
// var bgGradient = ctx.createLinearGradient(0, 0, 170, 0);
// bgGradient.addColorStop(0, "white");
// bgGradient.addColorStop(0.5, "#B0C4DE");
// bgGradient.addColorStop(1, "#4682B4")

// ctx.fillStyle = bgGradient;

// /* parameters reflect the full width and height of rectangle 
// and will fill the entire rectangle */
// ctx.fillRect(0, 0, 500, 250);

