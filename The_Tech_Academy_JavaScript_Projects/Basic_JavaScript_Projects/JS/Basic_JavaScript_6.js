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

//Reserved Word Example

//var d = return;  //Doesn't display in browser- it expects an expression to be used 
                    //since the word 'return' already means something in JS
//document.write(d); //**Both the variable being defined and the write method, if not commented, wont allow the rest of the code to work

document.write("<br>")

//Object constructor challenge

function animal(species, breed, age, sex) {  //make sure not to put a semi colon ' ; ' after the parenthesis of the parameters
                                            // otherwise it will not be considered a class
    this.animal_species = species;
    this.animal_breed = breed;
    this.animal_age = age;
    this.animal_sex = sex;
}
var Sassy = new animal("Cat", "Calico", 5, "female");
var Mike = new animal("Dog", "Golden Retriever", 1, "male");
function myFunction2() {
    document.getElementById("animals").innerHTML = 
    "Mom has a " + Sassy.animal_age + " year old " 
    + Sassy.animal_sex + " " + Sassy.animal_breed + " " + Sassy.animal_species;
}