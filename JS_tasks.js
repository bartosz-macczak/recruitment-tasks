//Recruitment tasks
//Task 6
function optionalPow(a, b) {
    var con = confirm("Compute the power of the first argument raised to the second one?");
    if (con == true) {
        return Math.pow(a, b);
    }
    else {
        return Math.pow(b, a);
    }
}

//Task 7
function fixage(array) {
    var results = "";
    for (var i = 0; i < array.length; i++) {
        if (array[i] >= 18 && array[i] <= 60) {
            results += array[i] + ",";
        }
    }

    if (results == "") {
        return "NA";
    }

    return results;
}
