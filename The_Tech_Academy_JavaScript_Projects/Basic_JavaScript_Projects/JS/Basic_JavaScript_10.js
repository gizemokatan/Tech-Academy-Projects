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

//Let keyword

function letFunction() {
    var x = 82;
    document.write(x);
    {
        let x = 33;
        document.write("<br>" + x);
    }
    document.write("<br>" + x);
}

function letFunction1() {
var x = 82;
	document.write(x);
	{
/*The var keyword in this block of code doesnt have block scope
it affects the rest of the code in the function scope */
		var x = 33;
		document.write("<br>" + x);
	}
    document.write("<br>" + x);
}

//return statement

function returnFunction(name) {
    return "Hello " + name;
}
var yup = returnFunction("Steve");
document.getElementById("return_it").innerHTML = yup;


//objects with property and method

let car = {
    make: "Hyundai",
    model: "Sonata",
    year: "2007",
    color: "navy",
    description: function() {
        return "The car is a " + this.year + " " + this.color + " " + this.make + " " + this.model;
    }
}
document.getElementById("car_object").innerHTML = car.description();

//break statement

function breakFunction() {
var text = "";
var i ;

/*variable i is initially zero, and the condition to be checked 
is i is less than 10, if true, text will equal text plus i.
In the for loop, if i equals to 3, break the loop and 
continue executing the code after the loop.*/
for (i = 0; i < 10; i++) {
    if (i === 3) {break; }
    text += i + "<br>";
}
document.getElementById("loop").innerHTML = text;
}

//continue statement

function contiFunction() {
    var text1 = "";
    var e;

/* variable e is initially zero and the condition to be checked
is e less than 10, if true, text will equal text plus e.
In the for loop, if e equals to 3, skip this step and continue
 with the next iteration in the loop.*/
    for (e = 0; e < 10; e++) {
        if (e === 3) {continue; }
        text1 += e + "<br>";
    }
    document.getElementById("continue").innerHTML = text1;
}