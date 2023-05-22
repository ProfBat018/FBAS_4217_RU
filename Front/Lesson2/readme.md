# Тема урока. SetTimeOut, SetInterval. Создание элементов через JS

setTimeout - это функция, которая позволяет вызвать функцию один раз через определённый интервал времени.

setInterval - это функция, которая позволяет вызвать функцию регулярно, повторяя вызов через определённый интервал времени.


# Как работает DNS

DNS - это Domain Name System, система доменных имен. Она позволяет переводить доменные имена в IP адреса и наоборот.

Когда мы вводим в браузере адрес сайта, например, google.com, то браузер отправляет запрос на DNS сервер, который возвращает IP адрес сайта.


# Event Bubbling и Event Capturing 

Event Bubbling - это процесс, при котором событие начинается с самого вложенного элемента и затем передаётся родительским элементам.

```html
<div class="parent">
    <div class="child">
        <div class="grandchild"></div>
    </div>
</div>
```

```javascript
const parent = document.querySelector('.parent');
const child = document.querySelector('.child');
const grandchild = document.querySelector('.grandchild');

parent.addEventListener('click', () => {
    console.log('parent');
});

child.addEventListener('click', () => {
    console.log('child');
});

grandchild.addEventListener('click', () => {
    console.log('grandchild');
});
```

# Event Capturing - это процесс, при котором событие начинается с родительского элемента и затем передаётся вложенным элементам.

```javascript
const parent = document.querySelector('.parent');
const child = document.querySelector('.child');
const grandchild = document.querySelector('.grandchild');

parent.addEventListener('click', () => {
    console.log('parent');
}, true);

child.addEventListener('click', () => {
    console.log('child');
}, true);

grandchild.addEventListener('click', () => {
    console.log('grandchild');
}, true);
``` 




