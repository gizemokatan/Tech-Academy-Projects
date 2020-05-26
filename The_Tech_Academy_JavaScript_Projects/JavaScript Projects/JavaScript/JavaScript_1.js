//switch statment; a type of conditional statement

function flavorFunction() {
    var flavor_output;
    var flavors = document.getElementById("flavor_input").value;
    var flavor_str = " is a great ice cream flavor!";
    switch(flavors) {

    //Each case will be evaluated based on user input
        case "Chocolate":
            flavor_output = "Chocolate" + flavor_str;
        break;
        case "Vanilla":
            flavor_output = "Vanilla" + flavor_str;
        break;
        case "Strawberry":
            flavor_output = "Strawberry" + flavor_str;
        break;
        case "Mint Chip":
            flavor_output = "Mint Chip" + flavor_str;
        break;
        case "Bananas Foster":
            flavor_output = "Bananas Foster" + flavor_str;
        break;
        case "Cookies and Cream":
            flavor_output = "Cookies and Cream" + flavor_str;
        break;

    /*default keyword will prompt a user to enter an item 
    exactly as written from the list if the entry doesn't match a case */
        default:
            flavor_output = "Please enter a flavor exactly as written on the above list.";
    }
    document.getElementById("output").innerHTML = flavor_output;
}