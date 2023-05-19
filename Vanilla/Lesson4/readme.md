# Тема урока.
## Типы данных, условия, циклы, nullable.


### Типы данных в JS.
В JS есть 7 типов данных:
1. Number - числа
2. String - строки
3. Boolean - логический тип
4. Null - пустое значение
5. Undefined - неопределенное значение
6. Object - объект
7. Symbol - символ

// Рассмотрим пример типа Symbol 
```javascript

let id = Symbol("id");

console.log(id);
```

Тип данных Symbol используется для создания уникальных идентификаторов.
<br>
Зачем не делать просто строку или hash ? 
<br>
Потому что Symbol не будет повторяться, даже если мы создадим два одинаковых Symbol.


# Разница между var и let
* `var` - глобальная переменная.
* `let` - локальная переменная.


### var
```javascript
var a = 5;

if (a) {
    a = 'elvin';
    var b = 10;
}
console.log(a)
console.log(b)
```

### let
```javascript
let a = 5;

if (a) {
    a = 'hello';
    let b = 10;
}

b = 11; // сам создается. Это новый let b

console.log(a); // hello
console.log(b);

```

# Области видимости переменных в JS
* Глобальная область видимости
* Локальная область видимости
* Блочная область видимости

### Глобальная область видимости
```javascript
let a = 5;
```

### Локальная область видимости
```javascript
function foo() {
    let a = 5;
}
```

### Блочная область видимости
```javascript
if (true) {
    let a = 5;
}
```

# Что такое hoisting. Поднятие переменных.
С помощью это штуки мы не встречаем ошибок ReferenceError.

```javascript
let x = 10;
if (true) {
    console.log(x);
    let x = 20;
}
console.log(x);
```

Нужно обязательно объявлять переменные в начале блока, чтобы не было ошибок.
Это и называется hoisting. 

### Type coercion

```javascript
let a = 5;
let b = '5';
console.log(a + b); // 55
```

### 
