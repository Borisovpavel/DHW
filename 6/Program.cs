Console.WriteLine("Enter 3-x number ");
string y = Console.ReadLine();
ThirdNumber(y);

void ThirdNumber(string somelnt)
{
    if (somelnt.Length == 3)
    {
        Console.WriteLine(somelnt.Trim(somelnt[0],somelnt[1]));
    }
    else
    {
        Console.WriteLine("wrond data try again ");
        somelnt = Console.ReadLine();
        ThirdNumber(somelnt);
    }
}