Console.Clear();

Console.Write("Введите число: ");
var a = Console.ReadLine();
float resultA = float.Parse(a);

if (resultA % 2 == 0)
{
    Console.WriteLine("Введенное число четное.");
}
else
{
    Console.WriteLine("Введенное число нечетное.");
}