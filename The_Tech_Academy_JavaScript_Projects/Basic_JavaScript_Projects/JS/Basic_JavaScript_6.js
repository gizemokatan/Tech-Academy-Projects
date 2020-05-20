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