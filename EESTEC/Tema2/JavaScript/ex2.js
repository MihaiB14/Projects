// Bălan Mihai 
var input = `DDUUUUDDDDUUUUDDUUUUDDUUDDUUDDDDDUUUUUDDUUDDDDUUUUUUDDDDDDDDDUUUUUDD`;
var altitude = 0;
var numberOfvalleys = 0;
var numberOfhills = 0;
var hills;
var valleys

function calculateAltitude(char) {
    if (char == `D`) {
        altitude -= 10;
    } 
    else {
        altitude += 10;
    }

    if (altitude == 0 && char == 'D') {
        numberOfhills++;
    }
    else if (altitude == 0 && char == 'U') {
        numberOfvalleys++;
    }
}

for (var i = 0; i < input.length; i++) {
    calculateAltitude(input.charAt(i));
}

if (numberOfhills > 1) {
    hills = `${numberOfhills} dealuri`;
}
else {
    hills = `un deal`;
}

if (numberOfvalleys > 1) {
    valleys = `${numberOfvalleys} vai`;
}
else {
    valleys = `o vale`;
}

console.log(`Ati parcurs ${valleys} si ${hills}.`);