Console.Clear();

Console.Write("Введите первое число: ");
var a = Console.ReadLine();
int resultA= int.Parse(a);
Console.Write("Введите второе число: ");
var b = Console.ReadLine();
int resultB = int.Parse(b);
Console.Write("Введите третье число: ");
var c = Console.ReadLine();
int resultC = int.Parse(c);

var max = resultA;

if (resultA > resultB)
{
   if (resultA > resultC)
    {
        max = resultA;
    }
    else
    {
        max = resultC;
    }
}
else
{
    if (resultB > resultC)
    {
        max = resultB;
    }
    else
    {
        max = resultC;
    }

}


Console.WriteLine(max);
