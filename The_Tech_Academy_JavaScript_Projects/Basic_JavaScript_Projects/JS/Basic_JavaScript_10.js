//Define and name a function
function call_loop() {

//define a variable; value is left unassigned
    var digit = "";
    var x = 1;

/* The while statement checks if x is less than 11, if True, 
it executes, and digit gets assigned 'digit' plus 'x' and a break tag*/
    while (x < 11) {
        //<br> will space lines of text
        digit += x + "<br>";
        x++
    }
    document.getElementById("loop").innerHTML = digit;
}


//String length property

function lengthFunction() {
    var str = "Hello World!";
    var l = str.length;
    document.getElementById("length").innerHTML = l;
}


//For loop

//define global variables
var instruments = ["Guitar", "Drums", "Piano", "Bass", "Violin"];
var content = "";
var y;

//define and name a function
function forLoop() {

/*variable y is set at zero.
The for loop checks the condition if 'y' is less than the length of
items in 'instruments' and executes the loop.
content will be equal to content plus position of 'y' in instruments.
*/
    for (y = 0; y < instruments.length; y++) {
        content += instruments[y] + "<br>";
    }
    document.getElementById("list_of_instruments").innerHTML = content;
}

//Arrays are objects- listed in the object data type

function catPics() {

//catPicture is the object
    var catPicture = [];

//there are 3 indexes and properties for each
    catPicture[0] = "sleeping";
    catPicture[1] = "playing";
    catPicture[2] = "eating";
    document.getElementById("cat").innerHTML = "In this picture, the cat is " +
    catPicture[2] + ".";
}

//Array 

function array_Function() {
    var teas = [];
    teas[0] = "Green tea";
    teas[1] = "Black tea";
    teas[2] = "Roobios tea";
    document.getElementById("array").innerHTML = "I like to drink " +
    teas[0] + ".";
}

//Constant keyword

function constantFunction() {

//create an object using const keyword and define properties with values
    const musical_instruments = {type: "Violin", family: "string", brand: "Fender", color: "black"};
    musical_instruments.color = "blue";
    musical_instruments.price = "$900";
    // document.getElementById("constant").innerHTML = "The cost of the " +
    // musical_instruments.color + " " + musical_instruments.type + " was " + musical_instruments.price + ".";

    //display a string that includes the added property value and the changed property value
    document.getElementById("constant").innerHTML = " The " + musical_instruments.type +
    " is in the " + musical_instruments.family + " family of instruments.";
}
