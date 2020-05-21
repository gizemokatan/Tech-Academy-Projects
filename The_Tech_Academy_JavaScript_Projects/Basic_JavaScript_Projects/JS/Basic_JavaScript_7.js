//Scope

//global variable
var x = 10;   //Must comment global variable code in order for code below 
                //to display that 'x is not defined' in the local variable,
                //otherwise this variable is accessed by all functions in the program
function addNums1() {
    document.write(20 + x + "<br>");
}
function addNums2() {
    document.write(x + 100);
}
addNums1();  //Returns the value of the expression
addNums2();

document.write("<br>")
document.write("<br>")

//local variable
function addNums3() {
    var x = 1;
    document.write(20 + x + "<br>");
}
function addNums4() {
    document.write(x + 100);
}
addNums3();
addNums4();

document.write("<br><br>")

//error example of local variable
function addNums5() {
    var x = 5;
    console.log(15 + x);
}
function addNums6() {
    console.log(x + 100);
}
addNums5();
addNums6();

document.write("<br><br>")

// if conditional statement

function getDate() {
    if (new Date().getHours() < 19) { //'if' is the branch and the rest is the conditional statement to be checked
                                        // 19 stands for 7:00 pm; the computer lists hours as integers between 0 and 23
        document.getElementById("Greeting").innerHTML = "How are you today?";
    }
}

//Own if statement

function getDay() {
    if (new Date().getDay() == 3) {  // the weekdays start with Sunday as 0, therefore Wednesday is 3
        document.getElementById("Weekday").innerHTML = "Happy Hump Day!"
    }
}

document.write("<br><br>")

//else statement

function ageFunction() {
    age = document.getElementById("age").value;
    if (age >= 18) {
        vote = "You can vote!";
    }
    else {
        vote = "You are not old enough to vote.";
    }
    document.getElementById("How_old").innerHTML = vote;
}

document.write("<br><br>")

//if and else statements

function birthYear() {  //Define and name a function
    year = document.getElementById("yearBorn").value; //set a variable equal to the user input value
    if (year <= 2015) {  //if branch will execute if the user inputs a year less than or equal to 2015, because this statement will be true
        start_school = "You're child can start Elementary School!";  //this is the variable we made to be able to display the result
    }
    else {              //otherwise, if the user input is greater than year 2015, this else statement will be executed
        start_school = "You're child is not old enough to start Elementary School.";  
    }
    document.getElementById("startSchool").innerHTML = start_school; //this dispalys the result in the HTML element with 'startSchool' id
}
