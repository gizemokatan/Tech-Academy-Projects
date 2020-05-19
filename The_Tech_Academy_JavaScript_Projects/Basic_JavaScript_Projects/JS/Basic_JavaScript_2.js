function myFunction() {  //Define function and name it
    var str = "My favorite color is green!";  //Define variable and gave it a string value
    var result =  str.fontcolor("green");  //Use fontcolor method on the str variable
    document.getElementById("green_text").innerHTML = result; //Put the value of result into the HTML element with 'green_text' id
}

function learnFunction() {
    var sentence = "How sweet it is";
    sentence += " to be loved by you.";
    document.getElementById("learn").innerHTML = sentence
}