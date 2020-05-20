function my_dictionary() {  //defin and name a funtion for a dictionary
    var student = {        // define a variable given the following key value pairs
        firstName: "Nicson",
        lastName: "Martinez",
        age: 27,
        averageGPA: 4.0,
        averageGPA: 3.5 //creating another key with the same name will skew results
                        // calling student.averageGPA will only result in the second KVP value of 3.5
    };
    document.getElementById("dictionary").innerHTML = student.averageGPA;
}