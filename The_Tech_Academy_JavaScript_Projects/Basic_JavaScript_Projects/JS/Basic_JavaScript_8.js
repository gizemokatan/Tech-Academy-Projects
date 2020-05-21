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
