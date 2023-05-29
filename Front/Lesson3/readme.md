## Базовые знания по Web Security

### HTTPS 
Hyper Text Transfer Protocol Secure (HTTPS) — расширение протокола HTTP для поддержки шифрования в целях повышения безопасности. В HTTPS применяется шифрование по протоколу SSL/TLS. HTTPS использует порт 443/TCP.

### CORS 
Cross-Origin Resource Sharing (CORS) 
Предположим что выв написали свой API
и через Javascript вы делаете запросы с Front-End
на Back-End. Но если вы попытаетесь сделать запрос,
то скорее всего ответ вы не получите, потому что нужно дать разрешение на запросы с другого домена.

### CSRF
Cross-Site Request Forgery (CSRF) — межсайтовая подделка запроса.
Это тип атаки на сайт, при которой несанкционированные команды выполняются от имени аутентифицированного пользователя.

Предположим у нас есть форма. И мы сделали `submit`, то есть послали запрос.
Кто-то по середине пути перехавтил мой запрос, изменил и замоскировался под меня.

### XSS
Cross-Site Scripting (XSS) — межсайтовый скриптинг.
Пример: 
```js
<script>alert('XSS')</script>
```
Вам надо быть осторожным с тем, что вы вводите в формы.
По факту `XSS` также называют Js Injection.

Как защититься от `XSS`?
1. Экранируйте вывод.
2. Используйте CSP (Content Security Policy).
3. Используйте HttpOnly для кук.
4. Используйте X-XSS-Protection заголовок.
5. Используйте Content-Type: nosniff заголовок.
6. Используйте санитайзеры.

### OWASP Security Risks

OWASP - это некоммерческая организация, которая занимается безопасностью веб-приложений. Она публикует список самых распространенных уязвимостей веб-приложений, который называется OWASP Top 10.

1. Injection
2. Broken Authentication
3. Sensitive Data Exposure
4. XML External Entities (XXE)
5. Broken Access Control
6. Security Misconfiguration
7. Cross-Site Scripting XSS
8. Insecure Deserialization
9. Using Components with Known Vulnerabilities
10. Insufficient Logging & Monitoring




