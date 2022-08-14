Console.WriteLine("Enter some day of a week (1.2.3.4.5.6.7)");
string dayOfAWeek = Console.ReadLine();
if (dayOfAWeek.Equals("6") || dayOfAWeek == "7")
{
    Console.WriteLine("WeekEnd ");
}
else Console.WriteLine("nah");
