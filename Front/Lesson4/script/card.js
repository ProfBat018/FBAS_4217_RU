const cards = document.querySelector('.cards');
const getBtn = document.querySelector('#car-request');

// ajax call to http://localhost:8000/cars with XMLHttpRequest

function createCards(cars) {
    cars.message.forEach(car => {
        const card = document.createElement('div');
        card.classList.add('card');
        card.innerHTML = `
        <div class="card-img">
            <img id="card-img-content"
        </div>
                <img src="${car.image}">
            <div class="card-body">
                <h3>${car.make}</h3>
                <h6>${car.model}</h6>
                <p>${car.year}</p>
            </div>
        `;
        cards.appendChild(card);
    });
}

const xhr = new XMLHttpRequest(); // http request

let cars = null;

getBtn.addEventListener('click', () => {
    event.preventDefault(); // предотвращает перезагрузку страницы

    xhr.open('GET', 'http://localhost:8000/cars'); // открывает соединение с типом запроса GET

    xhr.send(); // делает запрос

    xhr.addEventListener('load', function () { // когда запрос загрузился
        if (this.status === 200) { // если статус запроса 200, то есть успешный
            cars = JSON.parse(this.responseText); // парсим json
            createCards(cars); // создаем карточки
        }
    });
});