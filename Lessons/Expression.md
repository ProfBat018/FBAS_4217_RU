# Expression 

```c#
void foo(Expression<Func<int, bool>> exp)
{
    Console.WriteLine(exp);    
}

void foo2(Func<int, bool> exp)
{
    Console.WriteLine(exp);
}

```

Разница между этими двумя методами в том, что в первом случае мы передаем выражение, а во втором делегат.

Вызов метода foo:

```c#
foo(x => x > 5);
```

Вывод:

```c#
x => (x > 5)
```

Вызов метода foo2:

```c#
foo2(x => x > 5);
```

Вывод:

```c#
System.Func`2[System.Int32,System.Boolean]
```



