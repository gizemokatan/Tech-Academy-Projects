document.writeln(typeof 3)
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

document.writeln(2E310);
document.writeln(-3E310);