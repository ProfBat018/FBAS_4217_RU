# Тема урока. Введение в Jquery

## Что такое Jquery ?

Jquery - это библиотека JavaScript, которая позволяет упростить работу с JavaScript веб-страницы. Jquery позволяет сделать множество вещей, но самое главное - это то, что она позволяет легко и быстро находить элементы на странице и изменять их.

## Подключение Jquery

Для того, чтобы использовать Jquery, его нужно подключить к странице. Для этого существует несколько способов:
1. Скачать Jquery с сайта [jquery.com](https://jquery.com/) и подключить к странице через тег script.
2. Подключить Jquery с помощью CDN. Для этого нужно вставить в тег script ссылку на CDN. Например, для подключения последней версии Jquery нужно вставить в тег script следующую ссылку: `https://code.jquery.com/jquery-3.5.1.min.js`
3. Подключить Jquery с помощью NPM. Для этого нужно ввести в консоли команду `npm install jquery` и подключить Jquery к странице через тег script.

***Остальные способы показывать уже не буду***

## Зачем нам нужен Jquery ? Spoiler: Мы его будем часто использовать

Jquery нужен для того, чтобы упростить работу с JavaScript. Например, если мы хотим изменить цвет фона элемента, то в JavaScript нам нужно будет написать следующий код:

```javascript
let header1 = document.querySelector('.header1');
header1.style.backgroundColor = 'red';

let header2 = $('.header2');
header2.css('background-color', 'red');
```

Например Toggle menu в  JS и Jquery:

```javascript
// JS
let menu = document.querySelector('.menu');
let menuButton = document.querySelector('.menu-button');

menuButton.addEventListener('click', () => {
    menu.classList.toggle('active');
});

// Jquery
let menu = $('.menu');
let menuButton = $('.menu-button');

menuButton.on('click', () => {
    menu.toggleClass('active');
});

``` 

В jquery уже есть готовые методы для работы с элементами, поэтому нам не нужно писать их сами. Все что нам нужно - это вызвать нужный метод и передать ему нужные параметры.

Методы в Jquery вызываются следующим образом: `$(selector).method(params)`

Список методов: 
* `addClass(className)` - добавляет класс элементу
* `removeClass(className)` - удаляет класс у элемента
* `toggleClass(className)` - добавляет класс элементу, если его нет, и удаляет, если есть
* `hasClass(className)` - проверяет, есть ли у элемента класс
* `css(property, value)` - изменяет css свойство у элемента
* `attr(attribute, value)` - изменяет атрибут у элемента
* `removeAttr(attribute)` - удаляет атрибут у элемента
* `html(html)` - изменяет html содержимое элемента
* `text(text)` - изменяет текстовое содержимое элемента
* `val(value)` - изменяет значение элемента
* `on(event, callback)` - добавляет обработчик события
* `off(event, callback)` - удаляет обработчик события

## Анимации в Jquery

Jquery позволяет легко создавать анимации. Для этого существует метод `animate(params, duration, callback)`. В этом методе мы передаем параметры, которые хотим изменить, длительность анимации и функцию, которая будет вызвана после окончания анимации.

Например, если мы хотим изменить цвет фона элемента, то в JavaScript нам нужно будет написать следующий код:

```javascript

// JS
let header1 = document.querySelector('.header1');
header1.style.backgroundColor = 'red';

// Jquery

let header2 = $('.header2');
header2.animate({
    backgroundColor: 'red'
}, 1000, () => {
    console.log('Анимация завершена');
});
```





