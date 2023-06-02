# Что такое AJAX ?

AJAX - это аббревиатура от Asynchronous JavaScript and XML (асинхронный JavaScript и XML). AJAX - это набор веб-технологий, который позволяет веб-страницам обмениваться данными с сервером без перезагрузки страницы. Это позволяет обновлять содержимое веб-страницы частично, что улучшает пользовательский опыт.

AJAX - это не язык программирования, а набор технологий, которые работают вместе. AJAX представляет собой комбинацию:
* HTML и CSS для представления
* DOM для взаимодействия и отображения
* XML и XSLT для обмена и манипулирования данными
* XMLHttpRequest для асинхронного обмена данными
* JavaScript для связи всего вместе
* Есть метод fetch() для обмена данными с сервером

Можно использовать как XMLHttpRequest, так и fetch() для обмена данными с сервером. Оба этих метода асинхронны, что означает, что они не блокируют выполнение кода JavaScript. Это позволяет веб-странице обновлять только часть страницы без перезагрузки.

Правда если вы делаете ajax запрос через method post в форме, то тогда страница перезагрузится, но это можно исправить, если в js коде написать event.preventDefault()

# Как работает AJAX ?

AJAX работает путем отправки запроса на сервер, получения ответа и обновления части страницы с помощью JavaScript. AJAX использует XMLHttpRequest объект для взаимодействия с сервером. XMLHttpRequest - это встроенный объект JavaScript, который позволяет клиенту обмениваться данными с сервером без перезагрузки страницы.

XMLHttpRequest может использоваться для получения данных в формате XML, JSON или HTML. Он также может использоваться для отправки данных на сервер в этих форматах.


