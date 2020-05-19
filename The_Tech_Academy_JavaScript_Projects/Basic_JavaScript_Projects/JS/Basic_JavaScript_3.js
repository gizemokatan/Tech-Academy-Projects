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