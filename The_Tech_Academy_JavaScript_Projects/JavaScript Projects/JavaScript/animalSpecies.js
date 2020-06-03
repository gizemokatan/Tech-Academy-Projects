function displayType(animal) {
    var animalSpecies = animal.getAttribute("data-animal-type");
    alert(animalSpecies + " is in the " + animal.innerHTML + " class.");
}

// Functions to open and close the popup form.
function openForm() {
    document.getElementById("animalForm").style.display = "block";
}

function closeForm() {
    document.getElementById("animalForm").style.display = "none";
}