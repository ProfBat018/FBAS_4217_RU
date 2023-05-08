# SCSS vs SASS

* SCSS - со скобками
* SASS - без скобок

Для того чтобы запустить компиляцию sass в css нужно выполнить команду:

```bash
sass --watch scss:css
```

Но так как мы работаем в VS Code или WebShorm, то можно воспользоваться плагином Live Sass Compiler

# Особенности SCSS над обычным CSS
* Вложенность - позволяет не писать повторяющиеся селекторы
* Переменные - позволяют хранить в одном месте значения, которые могут повторяться в разных местах
* Миксины - позволяют хранить в одном месте повторяющиеся стили
* Функции - позволяют хранить в одном месте повторяющиеся вычисления
* Импорты - позволяют разбивать стили на несколько файлов
* Условия - позволяют писать условия
* Циклы - позволяют писать циклы

### Вложенность
```scss
// SCSS
.container {
  width: 100%;
  .item {
    width: 50%;
  }
}
```
```css
/* CSS */
.container {
  width: 100%;
}
.container .item {
  width: 50%;
}
```

### Переменные
```scss
// SCSS
$color: #fff;
$bg-color: #000;
.container {
  color: $color;
  background-color: $bg-color;
}
```
```css
/* CSS */
.container {
  color: #fff;
  background-color: #000;
}
```

### Миксины
```scss
// SCSS
@mixin flex($direction, $justify, $align) {
  display: flex;
  flex-direction: $direction;
  justify-content: $justify;
  align-items: $align;
}
.container {
  @include flex(row, center, center);
}
```
```css
/* CSS */
.container {
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
}
```

### Функции
```scss
// SCSS
@function calc($value) {
  @return $value * 2;
}
.container {
  width: calc(100px);
}
```
```css
/* CSS */
.container {
  width: 200px;
}
```

### Импорты

Для чего [`import`](https://sass-lang.com/documentation/at-rules/import) вообще нужны


### Условия 
```scss
// SCSS
$color: #fff;
$bg-color: #000;
.container {
  @if $color == #fff {
    color: $color;
  } @else {
    color: #000;
  }
  @if $bg-color == #000 {
    background-color: $bg-color;
  } @else {
    background-color: #fff;
  }
}
```

### Циклы
```scss
// SCSS
@for $i from 1 through 3 {
  .item-#{$i} {
    width: 100px * $i;
  }
}
```
```css


