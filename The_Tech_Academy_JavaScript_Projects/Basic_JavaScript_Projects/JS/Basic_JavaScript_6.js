function ride_function() {
    var height, can_ride;
    height = document.getElementById("height").value;
    can_ride = (height < 52) ? "You are too short":"You are tall enough";  //This line reads that if it's true that user height is less than 52 centimeters
                                                                    // then True, You are too short to ride, OTHERWISE false, You are tall enough.
    document.getElementById("ride").innerHTML = can_ride + " to ride.";
}

document.write("<br>")

function vote_function() { //Define and name a function
    var age, can_vote;  //Define two variable 
    age = document.getElementById("age").value;  //First variable has a value of the result of a user input
    can_vote = (age < 18) ? "You are not old enough to vote.":"You can vote!";  //Second variable performs the ternary operation;
                                                                                //States if it's true that the user input is less than 18 then True, but if user input is 18 or older then False
    document.getElementById("result").innerHTML = can_vote;  //Displays the result on the HTML element with 'result' id
}

document.write("<br>")

function vehicle(make, model, year, color) {  //Define and name a class with four parameters
    this.vehicle_make = make;  //allows for possession to take place when we call a specified variable
    this.vehicle_model = model;
    this.vehicle_year = year;
    this.vehicle_color = color;
}
var Jack = new vehicle("Dodge", "Viper", 2020, "red"); //Define variable and create a new instance of our vehicle class
var Erik = new vehicle("Ford", "Pinto", 1971, "mustard");
function myFunction() {  //Define and name a function
    document.getElementById("keywords_and_constructors").innerHTML =   //Display the output of a specified instance
    "Erik drives a " + Erik.vehicle_color + "-colored " + Erik.vehicle_model +
    " manufactured in " + Erik.vehicle_year;
}

//Assignment Example

var Courtney = new vehicle("Hyundai", "Sonata", 2007, "navy blue");
function myFunction1() {
    document.getElementById("new_and_this").innerHTML = 
    "Courtney drives a " + Courtney.vehicle_color + " " + Courtney.vehicle_year
    + " " + Courtney.vehicle_make + " " + Courtney.vehicle_model;
}