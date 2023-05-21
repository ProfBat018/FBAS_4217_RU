# Классы и ключевое слово this

## Классы и объекты

```javascript
class User {
    constructor(name) {
        this.name = name;
    }

    sayHi() {
        alert(this.name);
    }
}
```
#### Какого типа бывают классы ?
- Обычные классы, которые создают объекты.
- Абстрактные классы, которые служат только для наследования.
- Финальные классы, которые не могут иметь потомков.
- Статические классы, которые предназначены для хранения утилитарных функций.


 #### Конструкторы в классах
```javascript
class User {
    constructor(name) {
        this.name = name;
    }
    sayHi() {
        alert(this.name);
    }
}
```

Что такое конструктор вы уже знаете, это функция которая вызывается при создании объекта. В классах она называется constructor.

В классе может быть только один метод с именем "constructor". Если их несколько – будет ошибка.

Методы вы тоже знаете, это обычные функции, которые добавляются в свойство класса.

#### Приколдесы с классами
```javascript
class User {
    sayHi() {
        console.log(`Hi, I am ${this.name}`);
    }
}

let omariott = new User();
omariott.name = "Omar Iott";
omariott.sayHi(); // Hi, I am Omar Iott

omariott.surname = "Haciyev";
console.log(omariott.surname);

omariott.sayBye = function() {
    console.log("Bye!");
}

omariott.sayBye(); // Bye!
```

####  Что по инкапсуляции ?
* `_` - protected
* `#` - private


# protected 
```javascript
class User {
    _name; // protected field
    _age;

    constructor(name, age) {
        this._name = name;
        this._age = age;
    }

    _sayHi() {
        console.log(`Hi, I am ${this._name}`);
    }
}
```

#### private
```javascript
class User {
    #name; // private field
    #age;

    constructor(name, age) {
        this.#name = name;
        this.#age = age;
    }

    #sayHi() {
        console.log(`Hi, I am ${this.#name}`);
    }
}

const user = new User('John', 30);



```


Можно ли сделать свойство только для чтения или только для записи ?
Да, можно. Для этого нужно использовать геттеры и сеттеры.

```javascript

class User {
    constructor(name) {
        this._name = name;
    }

    get name() {
        return this._name;
    }

    set name(value) {
        if (value.length < 4) {
            console.log("Имя слишком короткое.");
            return;
        }
        this._name = value;
    }
}
```

#### this 

В отличии от того же самого C#, в JavaScript ключевое слово this не является ссылкой на объект, а является ссылкой на контекст выполнения функции. Контекст выполнения объекта определяется тем, как она была вызвана.

```javascript

const user = {
    name: 'John',
    sayHi() {
        console.log(this.name);
    }
}

user.sayHi(); // John

const sayHi = user.sayHi;
sayHi(); // undefined

```

#### По сути this - совсем не то, что вы привыкли видеть в C#.

this - это не ссылка на объект, а ссылка на область видимости, где находится сущность.

```javascript
class A {
    name = `Sahibo`;
    aloha() {
        console.log(this);
        aloha2();
    }
}

class B {
    name = `Elvin`;

    aloha() {
        console.log(this);
    }
}


let a = new A();
let b = new B();

a.aloha();
b.aloha();

```


# Function borrowing

```javascript
const user = {
    name: 'John',
    sayHi() {
        console.log(this.name);
    }
}

const sayHi = user.sayHi;
sayHi(); // undefined
```


# Function binding
* call
* apply
* bind


### Call 

```javascript
const user = {
    name: 'John',
    sayHi() {
        console.log(this.name);
    }
}

const a = user.sayHi;
a.call(user); // John
```

### Apply
```javascript
const user = {
    name: 'John',
    sayHi() {
        console.log(this.name);
    }
}

const a = user.sayHi;
a.apply(user); // John
```


### Bind
```javascript
const user = {
    name: 'John',
    sayHi() {
        console.log(this.name);
    }
}

const sayHi = user.sayHi.bind(user);
sayHi(); // John
```

### Arrow function
```javascript
const foo = () => {
    console.log(this);
}

foo(); // window

```

```javascript

const foo = async () => {
    console.log(this);
}

await foo(); // window

```

```javascript

const foo = (a) => {
    console.log(a);
}
```
foo(5); // 5

### Бесконечные параметры

```javascript
const foo = (...args) => {
    console.log(args);
    console.log(typeof(args));
}

foo(1, 2, 3, 4, 5); 
// [1, 2, 3, 4, 5]
// object
```

### using this in arrow function

```javascript

const user = {
    name: 'John',
    sayHi: () => {
        console.log(this.name);
    }
}
```





