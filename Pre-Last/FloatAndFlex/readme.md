# Тема урока: "Float vs Flex"

## Что такое Float

Float - это свойство CSS, которое позволяет элементам выравниваться по левому или правому краю родительского элемента. Это свойство было создано для обтекания текстом картинок, но в дальнейшем было использовано для создания макетов.

```html

<div class="container">
  <div class="item">1</div>
  <div class="item">2</div>
  <div class="item">3</div>
</div>
```

```css
.container {
  width: 100%;
  height: 100vh;
  background-color: #ccc;
}

.item {
  width: 100px;
  height: 100px;
  background-color: #000;
  float: left;
}
```

####  Проблемы Float
* При использовании float, родительский элемент не учитывает высоту дочерних элементов.
* При использовании float, элементы теряют свои размеры.
* При использовании float, элементы выходят из потока документа.
* При использовании float, элементы могут пересекаться друг с другом.

## Что такое Flex

Flex - это свойство CSS, которое позволяет элементам выравниваться по горизонтали или вертикали. Это свойство было создано для создания макетов, но в дальнейшем было использовано для обтекания текстом картинок.

```html
   <div class="dfcontainer">
        <div class="dfitem">1</div>
        <div class="dfitem">2</div>
        <div class="dfitem">3</div>
    </div>
```

```css

    .dfcontainer {
        width: 100%;
        background-color: #ccc;
        display: flex;
        justify-content: flex-start;
        align-items: flex-start;
    }


    .dfitem {
        width: 100px;
        height: 100px;
        background-color: rgb(16, 98, 165);
        float: left;
    }
```

####  Проблемы Flex
* По моему мнению, проблем с flex нет.

## Какой способ лучше использовать
Flex лучше использовать, так как он решает все проблемы float. Использование float в современном вебе не рекомендуется.