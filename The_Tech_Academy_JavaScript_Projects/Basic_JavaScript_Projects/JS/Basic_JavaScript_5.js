document.writeln(typeof 3)  //gives the type of the value
document.writeln(typeof "song")

function myFunction() {
    document.getElementById("test").innerHTML = 0/0;
}

function myFunction1() {
    document.getElementById("test1").innerHTML = isNaN('Hello world!');
}

function myFunction2() {
    document.getElementById("test2").innerHTML = isNaN(007);
}

function infin() {  //define a function for an output of infinity
    document.writeln(2E310);
}

function negInfin() {  //define a function for an output of -infinity
    document.writeln(-3E310); 
}

function Bool() {  //using Boolean logic to result True
    document.writeln(10 > 2);
}

function Bool1() {  //using Boolean logic to result False
    document.writeln(10 < 2);
}

function mathOp() {
    console.log(2 + 2);
}

function newType() {  //converts the value to the type coercion it chooses
    document.write("10" + 5);
}

function BoolCon() {
    console.log(2 > 3);
}