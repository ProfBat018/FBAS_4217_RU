## Про сам JS

JS - это интерпретируемый, объектно-ориентированный, высокоуровневый, динамически типизированный язык программирования.


## What is defer?

Defer запускает скрипт после того, как весь HTML-документ будет полностью загружен и обработан браузером.

## Типы данных в JS ? 
В JavaScript есть 8 основных типов данных:
* `number` для любых чисел: целочисленных или чисел с плавающей точкой, целочисленные значения ограничены диапазоном ±253.
* `bigint` для целых чисел произвольной длины.
* `string` для строк. Строка может содержать ноль или больше символов, нет отдельного символьного типа.
* `boolean` для true/false.
* `null` для неизвестных значений – отдельный тип, имеющий одно значение null.
* `undefined` для неприсвоенных значений – отдельный тип, имеющий одно значение undefined.
* `object` для более сложных структур данных.
* `symbol` для уникальных идентификаторов. 
* `NaN` - not a number. Может возникнуть при делении на ноль или при неправильной математической операции. 

##  Как объявить переменную в JS ?
Есть три способа: 
* `const` - переменная, которая не может быть изменена после объявления.
* `let` - переменная, которая может быть изменена после объявления. Локальная
* `var` - переменная, которая может быть изменена после объявления. глобальная

## Как правильно называть переменные, функции, классы в JS ?
* Переменные и функции: camelCase
* Классы: PascalCase
* Константы: UPPERCASE_WITH_UNDERSCORES
* Приватные переменные: _camelCase
* Приватные методы: _camelCase
* Приватные константы: _UPPERCASE_WITH_UNDERSCORES
* Переменные, которые являются функциями-конструкторами: PascalCase

## Про типизацию в JS

JS - это динамически типизированный язык программирования. Это означает, что тип переменной не указывается явно. Вместо этого тип переменной определяется автоматически во время выполнения программы. Также это означает, что одна и та же переменная может использоваться для хранения разных типов данных.

Пример 
```javascript
var x = 1 // x - это число
x = 'hello' // x - это строка
```

Весь JS работает как dynamic в C#.

## Про явную и неявную типизацию в JS

Явная типизация - это когда тип переменной указывается явно. Например, в C# мы можем написать следующее:
```csharp
int x = 1;
```

Неявная типизация - это когда тип переменной определяется автоматически. Например, в JS мы можем написать следующее:
```javascript

var x = 1; // x - это число
x = 'hello'; // x - это строка
```

Явная типизация в JS - это когда мы указываем тип переменной явно, `как в Python`, но тип переменной определяется автоматически. Например, в JS мы можем написать следующее:
```javascript
var x = Number(1); // x - это число
```

## Про приведение типов в JS

Есть несколько вариантов приведения типов в JS:
* явное приведение типов - `Number('1')`
* неявное приведение типов - `1 + '1'`




