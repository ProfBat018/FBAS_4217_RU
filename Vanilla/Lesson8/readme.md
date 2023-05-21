# Lesson 8. JS Functions

#### Что мы сегодня пройдем.
- Function parameters
* * Default parameters
* * Rest parameters
- Arrow functions
- IIFEs
- Argument object
- Scope  & Function stack
* * Closure
* * Lexical Scoping
* * Recursion
- Built-in Functions

#### Function parameters
```javascript
function sum(a, b) {
  return a + b;
}
```

#### Default parameters
```javascript
function sum(a=1, b) {
  return a + b;
}
```

#### Rest parameters
```javascript
function sum(...args) {
    console.log(args)
}
```

#### Arrow functions
```javascript
const sum = (a, b) => a + b;
let sum = (a, b) => a + b;
```

#### IIFEs
IIFE - Immediately Invoked Function Expression
IIFE - используется для создания локальной области видимости, чтобы не засорять глобальную область видимости.

Его используют когда используется много переменных, и нам надо закрыть область вдимости, чтобы не засорять глобальную область видимости.

```javascript
(function() {
    console.log('IIFE')
})()
```

#### Argument object

В js по умолчанию функция может принимать любое количество аргументов, даже если они не указаны в сигнатуре функции.

```javascript
function sum() {
    console.log(arguments)
}
```

#### Scope  & Function stack
Scope - область видимости переменных.
Function stack - стек вызовов функций.

#### Closure
Замыкание - это функция внутри другой функции, которая имеет доступ к переменным внешней функции.

```javascript
function sum(a) {
    return function(b) {
        return a + b;
    }
}
```

У замыкания есть несколько приколов, давайте их рассмотрим на примере.

```javascript
function sum(a) {
    return function(b) {
        return a + b;
    }
}

let sum10 = sum(10);
let sum20 = sum(20);

console.log(sum10(5)); // 15
console.log(sum20(5)); // 25
```

Теперь максимально логичный вопрос - а зачем это нам надо ? 

Clousre, то есть замыкания используются для создания приватных переменных.

```javascript
function counter() {
    let count = 0;
    return function() {
        return ++count;
    }
}

let counter1 = counter();

console.log(counter1()); // 1

```

Так же Closure используется для асинхронных операций.

```javascript

function async() {
    let count = 0;
    setTimeout(function() {
        console.log(++count);
    }, 1000)
}

async();

```

#### Lexical Scoping
Лексическое окружение - это совокупность всех переменных и функций, которые доступны в текущей области видимости.


#### Recursion
Рекурсия - это когда функция вызывает сама себя.

```javascript
function sum(n) {
    if (n === 1) {
        return 1;
    }
    return n + sum(n - 1);
}
```

#### Built-in Functions
В js есть много встроенных функций, которые можно использовать в своих проектах.

```javascript
let str = 'Hello world';

console.log(str.length); // 11
console.log(str.toUpperCase()); // HELLO WORLD
console.log(str.toLowerCase()); // hello world
```
Дальше разбирайте сами, тут все просто и понятно.

# ***Правда не наделайте 🩼🩼🩼***





