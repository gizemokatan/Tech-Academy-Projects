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