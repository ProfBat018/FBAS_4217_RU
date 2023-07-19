# Подготовка к ASP.NET. Часть 1

### План
1. Повторить C# 
2. Повторить Системное программирование
3. Повторить Сетевое программирование
4. Повторить EF Core. 
5. Углубиться в оптимизацию EF Core запросов и 
посмотреть PLINQ

## Начинаем с повтора C# 
* OOP
* Ссылочные типы и значимые типы
* Структуры, классы, записи
* Массивы и коллекции
* Энумераторы
* Интерфейсы
* Делегаты и события
* Лямбда выражения
* TPL 
* LINQ


# По части ООП:
Вопросы: 
Что такое SOLID ? 
* S - Single responsibility principle. Каждая
сущность должна отвечать за что-то одно.
В данном случае под сущностью понимается класс, метод, стурктура, условие и т.д.
* O - Open-closed principle. Сущность должна быть открыта для расширения, но закрыта для изменения.
В данном случае под сущностью понимается класс, стурктура
* L - Liskov substitution principle. Наследующий класс должен дополнять, а не изменять базовый.
`Машина` - это дополнение к `Транспортному средству`, а не изменение, но если взять `Лошадь`, то это уже изменение, т.к. 
у лошади нет поведения транспортного средства.
* I - Interface segregation principle. Много специализированных интерфейсов лучше, чем один универсальный.
* D - Dependency inversion principle. Зависимость на абстракциях. Нет зависимости на что-то конкретное.
Как пример, если вы реализовали программу с видами оплаты: наличные, карта, онлайн, то вам не нужно будет менять код, 
если вы захотите добавить еще один вид оплаты, т.к. вы будете зависеть от абстракции `Оплата`, а не от конкретных реализаций.

Пример с буквой `D` в коде:
```csharp
interface ISerializable<T>
{
    bool Serialize<T>();
    T DeSerialize<T>();
}

class XMLSerializer : ISerializable<XMLSerializer>
{
    public bool Serialize<XMLSerializer>()
    {
        // ...
    }

    public XMLSerializer DeSerialize<XMLSerializer>()
    {
        // ...
    }
}

class JsonSerializer : ISerializable<JsonSerializer>
{
    public bool Serialize<JsonSerializer>()
    {
        // ...
    }

    public JsonSerializer DeSerialize<JsonSerializer>()
    {
        // ...
    }
}

class BinarySerializer : ISerializable<BinarySerializer>
{
    public bool Serialize<BinarySerializer>()
    {
        // ...
    }

    public BinarySerializer DeSerialize<BinarySerializer>()
    {
        // ...
    }
}
```

# По части Ссылочные типы и значимые типы:
### Ссылочные типы:
* Классы
* Интерфейсы
* Делегаты
* События


### Значимые типы:
* Структуры
* Перечисления

Если создать значимый тип в ссылочном типе, то он будет храниться в куче, а не в стеке.

# По части Структуры, классы, записи:

### Структуры:
* Хранятся в стеке
* Не могут наследоваться
* Не могут иметь конструктор без параметров
* Не могут быть абстрактными
* Не могут быть виртуальными
* Не могут содержать члены, которые инициализируются по умолчанию
* Может наследовать только от интерфейса

Пример: 
```csharp
struct Point
{
    public int X = 0;
    public int Y = 0;
}
```
Ошибка, т.к. структура не может содержать члены, которые инициализируются по умолчанию.


Они оба могут содержать поля, методы, свойства и конструкторы. Однако, есть несколько отличий между ними:

- Структуры передаются по значению, а классы передаются по ссылке.
- Структуры не могут наследоваться, а классы могут.
- Структуры не могут иметь явных конструкторов без параметров, а классы могут.
- Структуры не могут быть абстрактными, виртуальными или защищенными, а классы могут.

В целом, структуры используются для хранения небольших объемов данных, которые не нуждаются в наследовании или полиморфизме, а классы используются для создания объектов, которые могут иметь сложное поведение и наследоваться другими классами.


# Классы повторять мы не будем )) 



## Абстрактный класс против интерфейса.
Самое главное что вы должны понять раз и навсегда.

Классы хранят данные, интерфейсы хранят повение. Хоть когда то понятие между ними было размыто, но не сейчас.

`Абстрактный класс` - это класс, который не возможно создать. При этом он может хранитьт константы, конструкторы, поля, свойства, методы, события, индексаторы, вложенные типы, операторы, финализаторы, а также может быть унаследован.

`Интерфейс` - сущность, которая хранит только поведение. При этом он может хранить только методы, свойства, события, индексаторы.


# По части Делегаты и события:

### Делегаты:
* Делегаты - это типы, которые хранят ссылки на методы.
* События - это механизм, который позволяет классам сообщать другим классам о том, что произошло какое-то событие.

Зачем нужны делегаты ? 

Делегат - это окно для добавления внешнего метода в уже готовый класс.
Как пример - `RelayCommand`
    
```csharp

RelayCommand command = new(() => {
    MessaBox.Show("Hello");
});
```

Событие - раотает с делегатом. Событие - это механизм, который позволяет классам сообщать другим классам о том, что произошло какое-то событие.

```csharp

public class Button
{
    public event EventHandler Click;
}

public class Program
{
    public static void Main()
    {
        Button button = new();
        button.Click += Button_Click;
    }

    private static void Button_Click(object sender, EventArgs e)
    {
        // ...
    }
}
```

# По части Коллекций:
* System.Collections;
* System.Collections.Generic;


Пример из `System.Collections`:
```csharp
ArrayList arr = new() {1, 2, 3, 4, 5};

int num1 = arr[0]; // Error. Implicit conversion object to int

int num1 = (int)arr[0]; // unboxing

Console.WriteLine(num1);
```  

### boxing и unboxing
* `boxing` - это процесс преобразования типа значения в тип ссылки.
* `unboxing` - это процесс преобразования типа ссылки в тип значения.

Чтобы такого не было придумали `System.Collections.Generic`

Пример из `System.Collections.Generic`:
```csharp
List<int> arr = new() {1, 2, 3, 4, 5};

int num1 = arr[0]; // Ok
```

```csharp
class A<T> : where T : struct, new()
{
    public T Value { get; set; }
}
```

# Энумераторы 
* IEnumerable
* IEnumerator
* yield return & yield break

`IEnumerable` - это интерфейс, который определяет метод 
GetEnumerator, который возвращает IEnumerator.
`IEnumerator` - это интерфейс, который определяет свойства
Current, MoveNext и Reset.
Current - это ссылка текущий элемент в коллекции.
MoveNext - это метод, который перемещает указатель на
следующий элемент в коллекции.
Reset - это метод, который сбрасывает указатель на начало коллекции.

`yield return` - реализует ленивое вычисление. Это означает, что
каждый раз, когда вы вызываете MoveNext, будет вычисляться
следующий элемент в коллекции. Пример:

```csharp

public class Program
{
    public static void Main()
    {
        foreach (int num in GetNumbers())
        {
            Console.WriteLine(num);
        }
    }

    public static IEnumerable<int> GetNumbers()
    {
        yield return 1;
        yield return 2;
        yield return 3;
        yield return 4;
        yield return 5;
    }
}
```
`yield break` - это ключевое слово, которое останавливает
ленивое вычисление. Пример:

```csharp

public class Program
{
    public static void Main()
    {
        foreach (int num in GetNumbers())
        {
            Console.WriteLine(num);
        }
    }

    public static IEnumerable<int> GetNumbers()
    {
        int i = 0;
        while (i <= 10) 
        {
            if (i == 5)
            {
                yield break;
            }
            yield return i;
            i++;
        }
    }
}
```

```csharp
public class StringEnumerator : IEnumerator
{
    private readonly string[] _strings;
    private int _position = -1;

    public StringEnumerator(string[] strings)
    {
        _strings = strings;
    }

    public bool MoveNext()
    {
        _position++;
        return (_position < _strings.Length);
    }

    public void Reset()
    {
        _position = -1;
    }

    public object Current
    {
        get
        {
            try
            {
                for(int i = 0; i < _strings.Length; i++)
                {
                    if (i == _position)
                    {
                        yield return _strings[i];
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}
```

```csharp
string name = "Hello";

foreach (char c in name)
{
    Console.WriteLine(c);
}
```
* TPL
* LINQ
* Class Record


# TPL - Top Level Statements

Такой файл может быть только один. И вообще я люблю TPL, и вам советую его использовать.


# LINQ - это базовый набор extension методов для работы с коллекциями.

Существует несколько типов LINQ:
* LINQ to Objects
* LINQ to XML
* LINQ to SQL
* LINQ to Entities

### Пример моего extension метода: 
```csharp

public static class MyExtensions
{
    public static void Aloha(this string str)
    {
        Console.WriteLine(str);
    }
}

string name = "Elvin"
name.Aloha(); // Elvin
MyExtensions.Aloha(name); // Elvin

```

## LINQ to Objects - набор для 
System.Collections.Generic
System.Collections
Так же, не забываем, что он работает и с IEnumerable<T>

Основные методы:
* Where
* Select
* SelectMany
* OrderBy
* Min
* Max
* OrderByDescending


## LINQ to XML - набор для работы с XML. Забили на него, так как есть JSON.

## LINQ to SQL

Пример: 
```csharp

var a = from user in users
        where user.Age > 18
        select user;
        
Перевод:
var b = users.Where(user => user.Age > 18);
```

## LINQ to Entities. Да начнется ORM. Продолжение в 
[Entity Framework Tutrial](/ef.md)



