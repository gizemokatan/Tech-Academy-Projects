
function getReceipt() {
    // This initializes our string so it can get passed from 
    // function to function, growing line by line into a full receipt.
    var text1 = "<h3>You Ordered:</h3>";
    var runningTotal = 0;
    var sizeTotal = 0;
    var sizeArray = document.getElementsByClassName("size");
    for (var i = 0; i < sizeArray.length; i++) {
        if (sizeArray[i].checked) {
            var selectedSize = sizeArray[i].value;
            text1 = text1+selectedSize+"<br>";
        }
    }
    if (selectedSize === "Gluten-free Pizza") {
        sizeTotal = 8;
    } else if (selectedSize === "Personal Pizza") {
        sizeTotal = 6;
    } else if (selectedSize === "Medium Pizza") {
        sizeTotal = 8;
    } else if (selectedSize === "Large Pizza") {
        sizeTotal = 12;
    } else if (selectedSize === "Extra Large Pizza") {
        sizeTotal = 16;
    }
    runningTotal = sizeTotal;
    console.log(selectedSize+" = $"+sizeTotal+".00");
    console.log("size text1: "+text1);
    console.log("subtotal: $"+runningTotal+".00");
    // These variables will be passed on to each function.
    // getVegetables(runningTotal,text1);
    getToppings(runningTotal,text1);
};

function getToppings(runningTotal, text1) {
    var toppingTotal = 0;
    var selectedToppings = [];
    var toppingArray = document.getElementsByClassName("toppings");
    for (var j = 0; j < toppingArray.length; j++) {
        if (toppingArray[j].checked) {
            selectedToppings.push(toppingArray[j].value);
            console.log("selected topping item: ("+toppingArray[j].value+")");
            text1 = text1+toppingArray[j].value+"<br>";
        }
    }
    var toppingCount = selectedToppings.length;
    if (toppingCount > 1) {
        toppingTotal = (toppingCount - 1);
    } else {
        toppingTotal = 0;
    }
    runningTotal = (runningTotal + toppingTotal);
    console.log("total selected topping items: "+toppingCount);
    console.log(toppingCount+" topping - 1 free topping = "+"$"+toppingTotal+".00");
    console.log("topping text1:"+text1);
    console.log("Purchase Total: "+"$"+runningTotal+".00");
    document.getElementById("showText").innerHTML=text1;
    document.getElementById("totalPrice").innerHTML = "<h3>Total: <strong>$"+runningTotal+".00"+"</strong></h3>";
};

// function getVegetables(runningTotal, text1) {
//     var vegTotal = 0;
//     var selectedVeg = [];
//     var vegArray = document.getElementsByClassName("veggies");
//     for (var k = 0; k < vegArray.length; k++) {
//         if (vegArray[k].checked) {
//             selectedVeg.push(vegArray[k].value);
//             console.log("selected vegetable items: ("+vegArray[k].value+")");
//             text1 = text1+vegArray[k].value+"<br>";
//         }
//     }
//     var vegCount = selectedVeg.length;
//     if (vegCount > 0) {
//         vegTotal = (vegCount);
//     } else {
//         vegTotal = 0;
//     }
//     runningTotal = (runningTotal + vegCount);
//     console.log("total selected vegetable items: "+vegCount);
//     console.log(vegCount+" vegetable = $"+vegTotal+".00");
//     console.log("vegetable text1:"+text1);
// };