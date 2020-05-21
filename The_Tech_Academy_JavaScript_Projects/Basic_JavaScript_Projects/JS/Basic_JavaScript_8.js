//Concat() Method Ex
function fullSentence() {
    var one = "I have ";  //make sure to leave a space between the last word and apostrophe for spacing when linking the other strings
    var two = "made this ";
    var three = "into a complete ";
    var four = "sentence.";
    var whole_sentence = one.concat(two, three, four);  //Define a variable that uses the concat() method to connect the first variable to the other three
    document.getElementById("concatenate").innerHTML = whole_sentence;
}

document.write("<br><br>")

//Slice() Method Ex

function sliceMethod() {
    var text = "I would've gotten away with it if it hadn't been for those meddling kids";
    // document.getElementById("slice").innerHTML = text.length; //Provides the length of the string
    var section = text.slice(53, 72);  //Define and name another variabel to store the result from the slice method
    document.getElementById("slice").innerHTML = section; //Display the section that was extracted from the original string in the HTML element with 'slice' id
}

document.write("<br><br>")

//toUpperCase Method Ex

function upperFunction() {
    var text_now = "Hello world!";
    document.getElementById("upper_case").innerHTML = text_now.toUpperCase(); //always put parenthesis after a method otherwise 
                                                                            //its unable to execute
}

document.write("<br><br>")

//search() method ex

function searchFunction() {
    var strings = "Please find the first time 'find' is stated";
    var posi = strings.search("find"); //using the seacrh() method it locates the first occurance of the specified text in the string
    document.getElementById("search").innerHTML = posi; //Displays the number associated with the first character's position 'f' in the text
}
