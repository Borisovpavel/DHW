{
Console.WriteLine("Введите первое число:");
// Считываем строку, написанное пользователем в консоль и переформатируем в int
 int a = int.Parse( Console.ReadLine());
Console.WriteLine("Введите второе число:");
 int b = int.Parse( Console.ReadLine());
Console.WriteLine("Введите третье число:");
 int c = int.Parse( Console.ReadLine());
 if (a > b && a > c)
 {
    Console.WriteLine("a max = "+ a);
 }
 else if (b > a && b > c)
 {
    Console.WriteLine("b max = "+ b);
 }
 else if(c > b && c > a)
 {
    Console.WriteLine("c max = "+ c);
 }
}
 