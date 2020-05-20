function my_dictionary() {
    var student = {
        firstName: "Nicson",
        lastName: "Martinez",
        age: 27,
        averageGPA: 4.0
    };
    document.getElementById("dictionary").innerHTML = student.firstName;
}