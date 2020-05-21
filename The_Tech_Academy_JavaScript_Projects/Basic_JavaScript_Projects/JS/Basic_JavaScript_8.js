//Strings
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
//End Strings

document.write("<br><br>")

//Numbers
//toString method ex

function toString_Function() {
    var x = 182;
    var xstring = x.toString();  //define variable to hold the toString() method since we want to check the typeOf result later
    document.getElementById("num_to_string").innerHTML = xstring;
    document.getElementById("the_type").innerHTML = 
    typeof xstring;  //Dispalys the type as string since the toString() method was previously executed
}

document.write("<br><br>")

//toPrecision() method ex

function precisionFunction() {
    var i = 12938.3012987376112;
    document.getElementById("precise").innerHTML = i.toPrecision(10); //must provide a specifi number for the length of the variable to stop at
}

document.write("<br><br>")

//toPrecision() method using a string variable

function precisionFunction1() {
    var k = "550.5859568574";
    var h = Number(k);      //the Number() method will convert the string to a number, since toPrecision() method works on the data type number
    console.log(typeof h);
    document.getElementById("precise1").innerHTML = h.toPrecision(3);
}

document.write("<br><br>")

//toFixed() method ex

function fixedFunction() {
    var num = 4.5236;
    var n = num.toFixed(2);  //this method will cut the rest of the number off after the decimal point 
                            //after the specified two digits
    document.getElementById("fixed_num").innerHTML = n;
    console.log(typeof n);
}

document.write("<br><br>")

//valueOf() method ex

function valueFunction() {
    var num1 = 16.6;
    var m = num1.valueOf();
    document.getElementById("new_value").innerHTML = m;
    console.log(typeof m);
}
//End Numbers