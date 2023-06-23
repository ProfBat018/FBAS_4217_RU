# Тема Урока. Entity Framework 

## Что такое ORM ? 
Object relation mapping - это технология, которая позволяет нам работать с базой данных, как с объектами.

## Что такое ODBC ?

Open database connectivity - это драйвер, которые 
повзоляет нам работать с базой данных.

## Что такое ADO.NET ?

ADO.NET - это низкоуровневый `ORM` framework, который повзоляет нам 
работать на низком уровне с базой данных.

`ADO`, используя драйвер `ODBC`, позволяет нам
подключить базу данных к нашему приложению.

В нашем случе для этого мы скачиваем nuget `Microsoft.Data.SqlClient` 

SqlClient предоставляет нам классы для работы с базой данных.
Например:
* SqlConnection - главный класс, где с помощью `connection string` подключаемся к базе данных.
* SqlCommand - класс для команда
* SqlDataReader - класс для чтения данных
* SqlDataAdapter - класс для работы с данными в режиме `disconnected` mode
* DataSet - хранит мои данные в `RAM`
* DataTable - хранит мою таблицу в `RAM`
* SqlException - класс для обработки SQL ошибок 

## Что такое Entity Framework ?

Entity Framework - это `ORM` framework,
который позволяет нам работать с базой данных, как с объектами на высоком уровне.

Под капотом `EF` использует `ADO.NET` и `ODBC`.

EF core по умолчанию работает в режиме `disconnected` mode.
Именно поэтому, у нас есть советы. с помощью который мы можем делать оптимизации.

[Мой конспект по оптимизациям из группы 1221_RU](https://github.com/ProfBat018/FBMS_1221_RU/tree/ORM/Entity/EfficientQuerying)

[Вторая часть](https://github.com/ProfBat018/FBMS_1221_RU/tree/ORM/Entity/EfficientUpdate)







