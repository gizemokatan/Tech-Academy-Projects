// pops up an alert window before viewing the page, 
//  and prints the string in the body of the HTML

window.alert("Hello,world!");
document.writeln('Hello, world!');


// assigns a string to a variable, 
//  and writes the value of the string in the body of the HTML

var a = "Come say Hi!";
document.writeln(a);



// window.alert(x);
// var x = "My name is:";


// must have double quotation marks ending this string if there is a quote or apostrohpy in the str

// document.write("My question today is: \"How's your day going?\"");


// concatenating a string

// document.write("\"Be who you are and say what you feel,"
// + " because those who mind don\'t matter and those who matter don\'t mind.\""
// + "-Dr. Seuss");


// Assign string values to two variables and concatenate the variables together

var b = ("\"A spoonful of sugar helps the medicine go down,"
+ " the medicine go down... \"");
var c = "- Mary Poppins"
document.writeln(b, c)


// assign multiple variables in one statement and writes the selected variables value in the body of the HTML

var Family = "The Smiths", Dad = "Tim", Mom = "Sue", Daughter = "Marian";
document.writeln(Daughter);


// We created a variable that was a string called “green.” 
// We assigned that variable the color green

var green = "Tim";
var green = green.fontcolor("green");
document.writeln(green);
var purple = "Sue";
var purple = purple.fontcolor("purple");
document.writeln(purple);
var blue = "Marian";
var blue = blue.fontcolor("blue");
document.writeln(blue);


// set the value of an expression to a variable and wrote the variables output in the body of the HTML
y = 3 + 3;
document.writeln(y);