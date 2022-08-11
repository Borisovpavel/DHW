{
Console.WriteLine("Введите первое число:");
// Считываем строку, написанное пользователем в консоль и переформатируем в int
 int a = int.Parse( Console.ReadLine());
Console.WriteLine("Введите второе число:");
 int b = int.Parse( Console.ReadLine());
if(a > b)
{
    Console.WriteLine("Первое числобольше второго и равно = "+ a);
}
else if (b > a)
{
    Console.WriteLine("Второе число больше первого и ровно = " + b);
}
else
{
    Console.WriteLine("Первое и второе числа равны : " + a);
}
}
 