# Тема урока. Fetch and asynchronous code

### Начнем с fetch 
как я уже говорил, ajax делится на две части. XMLHttpRequest и fetch.
* XMLHttpRequest - это старый метод, который используется в основном для совместимости со старыми браузерами.
* fetch - это новый метод, который используется для современных браузеров.

### Fetch

Fetch - это новый стандарт для асинхронных запросов. Он построен на промисах, что делает его более удобным в использовании, чем XMLHttpRequest.

#### Как я говорил на системном программировнии Promise - это тоже самое что и Task в C#.
#### То есть это асинхронная задача, которая может быть выполнена в будущем.

### Пример fetch

```javascript

await fetch('https://jsonplaceholder.typicode.com/todos/1')
  .then(response => response.json())
  .then(json => console.log(json))
```

```js

let card = document.querySelector('.card');

card.addEventListener('click', async function () {
  let response = await fetch('https://jsonplaceholder.typicode.com/todos/1');
  let json = await response.json();
  console.log(json);
});
```

### За что отвечает then ? и что нам еще надо знать ?
then - это метод, который вызывается после того как выполнится fetch.
кроме then есть еще методы catch и finally.

#### catch - вызывается в случае ошибки
#### finally - вызывается в любом случае



