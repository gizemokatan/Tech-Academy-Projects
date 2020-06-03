// function validateForm() {
// //The second bracket is referencing the name attribute inside myForm
//     var fname = document.forms["myForm"]["fname"].value;
//     var lname = document.forms["myForm"]["lname"].value;
//     var email = document.forms["myForm"]["email"].value;
//     var phone = document.forms["myForm"]["phone"].value;
//     if (1 === 1) {
//         alert(fname);
//         return false;
//     }
//     if (lname === "") {
//         alert("Last Name must be filled out");
//         return false;
//     }
//     if (email === "") {
//         alert("Email Address must be filled out");
//         return false;
//     }
//     if (phone === "") {
//         alert("Phone Number must be filled out");
//         return false;
//     }
// }

// Form Validation to create an alert window.
var list_of_empty_fields = [];
function validateForm() {
    var field = document.getElementsByClassName("field");
    for (var i = 0; i < field.length; i++) {
        if (field[i].value === "") {
            list_of_empty_fields.push(field[i].id);
        }
    }

    if (list_of_empty_fields.length === 0) {
        alert("Your form was submitted successfully")
    }
    else {
        var empty_fields = list_of_empty_fields.toString();
        alert(empty_fields + " must be filled out")
    }
    console.log(list_of_empty_fields);
}


