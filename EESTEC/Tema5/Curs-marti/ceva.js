
/*
var foo = "foo";
let foo2 = "foo2";

function fun() {
    var foo = "Foo";
    let bar = "Bar";

    console.log(foo + " " + bar);
    {
        var moo = "Moo";
        let baz = "Bazz";
        console.log(moo, baz);
    }

    console.log(moo);
    console.log(baz);
}

fun();

var funcs = [];
for(let i = 0; i < 3; i++)  {
    funcs[i] = function() {
        console.log("My value: " + i);
    }
}

for( var j = 0; j < 3; j++) {
    funcs[j]();
}


window.onload = function() {
    let button = document.getElementsByClassName('clicky-button');

    for(let i = 0; i < button.length; i++ ){
        button[i].addEventListener('click', function() {
            console.log(`Clicked button ${i + 1}`);
        })
    }
}

const constantStaff = "Ceva";
//constantStaff = "Alteceva";
const constantObject = {
    a: 1
} 

let anotherObject = {
    a: 6
}

constantObject.b = 5;

console.log(constantObject);


let human = {
    hourseSinceLastAte: 7,
    shouldEat: function() {

        hourseLogic = () => {
            if(this.hourseSinceLastAte > 6) {
                return true;
            }
            else {
                return false;
            }
        }

        return hourseLogic();
    }
}

console.log(human.shouldEat());



let arrayToFilter = [1, 12, 45, 234, 2, 4];
console.log(arrayToFilter.filter(function(currentNUmber) {
    if(currentNUmber %2 == 0) {
        return true;
    }
    else {
        return false;
    }
}))

console.log(arrayToFilter.filter((currentNUmber) => currentNUmber % 2 == 0).map(currentNUmber => currentNUmber + 1));


let x; //1

setTimeout(() => {console.log(x)}, 1100); //4




setInterval( () => {
    console.log(x);
}, 1000);


setTimeout( () => {x = 2;},1000);//3
console.log(x); //undefind // 2
*/

/*
fetch("https://jsonplaceholder.typicode.com/users").then( promise => {
    promise.json().then(data => {console.log(data);})
});
*/
window.onload = () => {
    let personContainer = document.getElementById('person-container');
    fetch("https://jsonplaceholder.typicode.com/users").then( promise => {
        promise.json().then(data => {
            let persons = data;
            persons.forEach(person => {
                personContainer.innerHTML += `<p> ${person.name} on address ${person.address.street}</p>`;
            })
        });
    });
}


