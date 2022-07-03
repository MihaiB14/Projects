window.onload = function() {
    let displayValue = document.getElementById('display-value');
    let increment = document.getElementById('increment');
    let decrement = document.getElementById('decrement');

    increment.addEventListener('click', () => {
        displayValue.innerHTML = parseInt(displayValue.innerHTML) + 1;
    })

    decrement.addEventListener('click', () => {
        displayValue.innerHTML = parseInt(displayValue.innerHTML) - 1;
    })
}