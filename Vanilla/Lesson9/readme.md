# Что такое Strict Mode в JavaScript и зачем он нужен?
## Строгий режим в JavaScript

Строгий режим (strict mode) — это специальный режим работы интерпретатора JavaScript, который позволяет ему работать в более ограниченном режиме и выдавать больше ошибок. Строгий режим включается путём добавления строки "use strict" в начале файла или функции.

Пример:

```javascript
"use strict";
function foo() {
  // Это строгий режим.
  // Здесь можно, например, объявлять переменные только с помощью var.
}
```

Например в react по умолчанию в файле index.js включен строгий режим.

```javascript
import React from "react";
import ReactDOM from "react-dom";
import "./index.css";
import App from "./App";
import reportWebVitals from "./reportWebVitals";
    
ReactDOM.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>,
  document.getElementById("root")
);
```


