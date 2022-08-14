Console.WriteLine("Enter some 3-x number->> get second one part ");
string x = Console.ReadLine();
threelnOneOut(x);
void threelnOneOut(string somelnt)
{
    if (somelnt.Length == 3)
    {
        Console.WriteLine(somelnt.Trim(somelnt[0],somelnt[2]));
    }
    else
    {
        Console.WriteLine("wrong data try again ");
        somelnt = Console.ReadLine();
        threelnOneOut(somelnt);
    }
}