function addFunction () {  //Define funciton and name it
    var addition = 2 + 2;  //Define variable to value of expression
    document.getElementById("math").innerHTML = "2 + 2 = " + addition;  //Put the value of addition into the HTML element with 'math' id
}

function subFunction () {
    var subtraction = 5 - 2;
    document.getElementById("math2").innerHTML = "5 - 2 = " + subtraction; //give it a new id so it doesnt display the the result in the 'Add me' button when clicking the 'Subtract me' button
}

function multiplication () {
    var multiply = 6 * 8;
    document.getElementById("math3").innerHTML = "6 * 8 = " + multiply; // id 'math3' is yet another new id
}

function division () {
    var divide = 48 / 6;
    document.getElementById("math4").innerHTML = "48 / 6 = " + divide;
}

function moreMath () {  //define and name a function that does multiple operations
    var allOperaters = (1 + 2) * 10 / 2 - 5;
    document.getElementById("math5").innerHTML = "1 plus 2, multiplied by 10, divided in half and then subtracted by 5 equals " + allOperaters;
}

function Mod() {
    var remainderOperator = 25 % 6;
    document.getElementById("math6").innerHTML = "The remainder of 25 divided by 6 is: " + remainderOperator;
}

function negationOp () {
    var i = 10;
    document.getElementById("math7").innerHTML = -i;
}