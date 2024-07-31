//Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?

int a = 2;
int b = 5;

//Можно реализовать через присваивание кортежей https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/value-tuples#tuple-assignment-and-deconstruction
//Пока не могу ответить стоит ли так делать. Так как непонятны подводные камни этого инструмента.
(a, b) = (b, a);

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
