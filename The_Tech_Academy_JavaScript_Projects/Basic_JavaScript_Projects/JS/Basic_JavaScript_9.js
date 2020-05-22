//countdown function
function countdown() {
    var seconds = document.getElementById("seconds").value;  //user inputs the number of seconds

    function tick() { //nested function
        seconds = seconds - 1;  //the variable will be updated each time we subrtact 1, starting with user input
                                // ex.  user inputs 10 seconds, then 9 seconds would be stored in the variable, then 8 seconds, and so on, saving the new value each time
        timer.innerHTML = seconds; //displays the countdown each second on on th eHTML element with 'timer' id
        setTimeout(tick, 1000);  //this method causes a 1000 milisecond pause each time the function executes, allowing a pause in between the numbers
    if(seconds == -1) {  //if statement will execute once the value of 'seconds' reaches -1, then invokes the alert message
        alert("Time's up!");
    }
    }
    tick();  // calls the function 
}