const cards = document.querySelectorAll('.card');
const getBtn = document.querySelector('#car-request');
function transition() {
    if (this.classList.contains('active')) {
        this.classList.remove('active')
    } else {
        this.classList.add('active');
    }
}

cards.forEach(card => card.addEventListener('click', transition));

// ajax call to http://localhost:8000/cars with XMLHttpRequest

const xhr = new XMLHttpRequest(); // http request

const cars = null;

getBtn.addEventListener('click', () => {
    console.log('clicked')
    xhr.open('GET', 'http://localhost:8000/cars'); // opens a connection

    xhr.send(); // sends the request
    xhr.addEventListener('load', function() { // onload event
        if (this.status === 200) {
            cars = JSON.parse(this.responseText);
            console.log(cars);
        }
    });
});

