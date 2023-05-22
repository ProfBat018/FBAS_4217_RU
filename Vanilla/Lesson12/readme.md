# Итераторы и генераторы в JS

## Итераторы

Итераторы - это объекты, которые предоставляют последовательный доступ к своим элементам. Все итераторы имеют метод
next(), который возвращает объект с двумя свойствами: value и done. Свойство value содержит значение текущего элемента,
а done - логическое значение, которое указывает, закончился ли перебор элементов.
Без итераторов foreach работать не будет

```js
let arr = [1, 2, 3, 4, 5];
let iterator = arr[Symbol.iterator]();

console.log(iterator.next()); // { value: 1, done: false }
console.log(iterator.next()); // { value: 2, done: false }
console.log(iterator.next()); // { value: 3, done: false }
console.log(iterator.next()); // { value: 4, done: false }
console.log(iterator.next()); // { value: 5, done: false }
console.log(iterator.next()); // { value: undefined, done: true }
```

Чтобы вы понимали - это не особая фишка JS, точно также это работает и в Python.
Пример:

```python

 nums = [1, 2, 3, 4, 5]
 
 iterator = iter(nums)
 
 print(next(iterator)) # 1
 print(next(iterator)) # 2
 print(next(iterator)) # 3
 print(next(iterator)) # 4
 print(next(iterator)) # 5
 print(next(iterator)) # StopIteration
```

## Генераторы

Генераторы - это функции, которые могут быть приостановлены и возобновлены во время выполнения, оставляя их контекст

```js
function* omar() {
  yield 1;
  yield 2;
  yield 3;
  yield 4;
  yield 5;
}

let iterator = omar();

console.log(iterator.next()); // { value: 1, done: false }
console.log(iterator.next()); // { value: 2, done: false }
console.log(iterator.next()); // { value: 3, done: false }
console.log(iterator.next()); // { value: 4, done: false }
console.log(iterator.next()); // { value: 5, done: false }
console.log(iterator.next()); // { value: undefined, done: true }
```