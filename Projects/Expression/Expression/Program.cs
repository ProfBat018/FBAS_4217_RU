using System.Linq.Expressions;

void foo(Expression<Func<int, bool>> exp)
{
    Console.WriteLine(exp);    
}

void foo2(Func<int, bool> exp)
{
    exp(5);
    Console.WriteLine(exp);
}

void foo3(Expression<Func<int, int>> ex)
{
    Console.WriteLine(ex);
    
}
// foo2(x => x > 5);

foo(x => x > 5);
foo3(x => (5 + 5 + 5));






