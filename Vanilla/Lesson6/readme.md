# Темы урока:
* Prototypal inheritance
* Object Prototype
* Keyed Collections
* * map
* * set
* * weakmap
* * weakset
* Typed Arrays
* Equality algorithms
* * isLooselyEqual
* * isStrictlyEqual
* * isSameValueZero
* * isSameValue
* * isSameValueNonNumber


### Prototypal inheritance
* Прототипное наследование - это способ организации наследования, при котором объекты-потомки могут брать свойства и методы у объектов-предков.
* В JavaScript прототипное наследование реализуется через свойство `__proto__` объекта.
Пример:
```javascript
const parent = {
    name: 'Parent',
    sayHello() {
        console.log(`Hello, ${this.name}`);
    }
};

const child = {
    name: 'Child'
};

child.__proto__ = parent;

child.sayHello(); // Hello, Child
```
                                     
 В этом примере у нас есть два анонимных объекта `parent` и `child`. Объект `child` наследует свойство `name` и метод `sayHello` у объекта `parent`. Для этого мы устанавливаем свойство `__proto__` объекта `child` равным объекту `parent`.
 
Все системные методы начинаются с двух подчеркиваний `__`. Это сделано для того, чтобы разработчик не мог переопределить эти методы. Но в некоторых случаях, например, при реализации прототипного наследования, мы можем использовать эти методы.

### Object Prototype
* В JavaScript все объекты наследуют свойства и методы от объекта `Object.prototype`.
* `Object.prototype` - это объект, который является прототипом для всех объектов в JavaScript.
* Условно говоря - `Object.prototype` - это базовый конструктор для всех объектов в JavaScript.
Пример:
```javascript
const obj = {};

console.log(obj.__proto__ === Object.prototype); // true
```

### Keyed Collections
* Keyed Collections - это коллекции, которые используют ключи для доступа к элементам коллекции.
* В JavaScript существует 4 вида Keyed Collections:
* * Map - коллекция, которая хранит элементы в виде пары ключ-значение.
* * Set - коллекция, которая хранит только уникальные значения.
* * WeakMap - коллекция, которая хранит элементы в виде пары ключ-значение. Ключи в WeakMap могут быть только объектами.
* * WeakSet - коллекция, которая хранит только уникальные объекты. Объекты в WeakSet могут быть только объектами.
                                                                                                                 
### Map
Map - это коллекция, которая хранит элементы в виде пары ключ-значение.
Пример:
```javascript
const map = new Map();

map.set('name', 'John');
map.set('age', 30);

console.log(map.get('name')); // John
console.log(map.get('age')); // 30
```
                                   
### Set
Set - это коллекция, которая хранит только уникальные значения.
Пример:
```javascript
const set = new Set();

set.add('John');
set.add('John');
set.add('John');
set.add('John');
set.add('Elvin');

console.log(set); // Set { 'John', 'Elvin' }
```

### WeakMap
WeakMap - это коллекция, которая хранит элементы в виде пары ключ-значение. Ключи в WeakMap могут быть только объектами.

Пример работы с WeakMap. Когда нашему объекту надо присвоить какое то значение, например дату добавления в коллекцию.
```javascript
const weakMap = new WeakMap();

const obj = {name: 'Elvin', age: 21};

weakMap.set(obj, new Date());
```

### WeakSet
WeakSet - это коллекция, которая хранит только уникальные объекты. Объекты в WeakSet могут быть только объектами.
Пример:
```javascript
const weakSet = new WeakSet();

const obj = {name: 'Elvin', age: 21};

weakSet.add(obj);
weakSet.add(obj);
weakSet.add(obj);
```

### Typed Arrays
* Typed Arrays - это массивы, которые хранят только один тип данных.
Пример: 
```javascript
const arr = new Int16Array(5);
arr[0] = 10;
arr[1] = 20;
arr[2] = 30;
arr[3] = 40;
arr[4] = 50;

console.log(arr); // Int16Array [ 10, 20, 30, 40, 50 ]
```

В общем и целом Typed Arrays - это обычный строготипизированный массив 

### Equality algorithms
* Equality algorithms - это алгоритмы сравнения двух значений.
* В JavaScript существует 5 алгоритмов сравнения двух значений:
* * isLooselyEqual
* * isStrictlyEqual
* * isSameValueZero
* * isSameValue
* * isSameValueNonNumber

### isLooselyEqual
* isLooselyEqual - это алгоритм сравнения двух значений, который сравнивает значения с приведением типов.
При сравнении двух значений с помощью оператора `==` используется алгоритм isLooselyEqual.
Пример:
```javascript
console.log(1 == '1'); // true
```

### isStrictlyEqual
* isStrictlyEqual - это алгоритм сравнения двух значений, который сравнивает значения без приведения типов.
При сравнении двух значений с помощью оператора `===` используется алгоритм isStrictlyEqual.
Пример:
```javascript
console.log(1 === '1'); // false
```

### isSameValueZero
```javascript
console.log(isSameValueZero(5, 5)); // true
console.log(isSameValueZero(0, -0)); // true
console.log(isSameValueZero(NaN, NaN)); // true
console.log(isSameValueZero(5, '5')); // false
console.log(isSameValueZero(Infinity, Infinity)); // true
console.log(isSameValueZero(-Infinity, Infinity)); // false
```
### isSameValue

```javascript
console.log(isSameValue(5, 5)); // true
console.log(isSameValue(0, -0)); // false
console.log(isSameValue(NaN, NaN)); // false
console.log(isSameValue(5, '5')); // false
console.log(isSameValue(Infinity, Infinity)); // true
console.log(isSameValue(-Infinity, Infinity)); // false
```

### isSameValueNonNumber
isSameValueNonNumber - работает по приципу isSameValue, но не сравнивает числа.
```javascript
console.log(isSameValueNonNumber(5, 5)); // true
console.log(isSameValueNonNumber(0, -0)); // true
console.log(isSameValueNonNumber(NaN, NaN)); // true
console.log(isSameValueNonNumber(5, '5')); // false
console.log(isSameValueNonNumber(Infinity, Infinity)); // true
console.log(isSameValueNonNumber(-Infinity, Infinity)); // false
```