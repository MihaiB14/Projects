// Bălan Mihai

window.onload = function() {
    let button = document.querySelector('button[class = "buton"]');
    let members = document.querySelector('div[class = "members"]');
    let person;

    button.addEventListener('click', () => {
        fetch('https://jsonplaceholder.typicode.com/users').then(promise => {
            promise.json().then(data => {
               person = data;
            });
        });

        setTimeout(() => {
            fetch('https://jsonplaceholder.typicode.com/photos').then(promise1 => {
                promise1.json().then(data1 => {
                    for(let i in person) {
                        members.innerHTML += `<div class = "square">
                                                <img src="${data1[i].url}"/>
                                                <p class = "text">${person[i].name} on street ${person[i].address.street}</p>
                                            </div>`;
                    }
                });
            });
        }, 250);
    }); 
}

