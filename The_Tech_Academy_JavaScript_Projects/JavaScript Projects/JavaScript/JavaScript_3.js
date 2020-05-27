function displayType(animal) {
    var animalSpecies = animal.getAttribute("data-animal-type");
    alert(animalSpecies + " is in the " + animal.innerHTML + " class.");
}