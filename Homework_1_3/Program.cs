Console.Clear();

Console.Write("Введите число: ");
string a = Console.ReadLine();
int resultA = int.Parse(a);
int i = 1;

if (resultA > 0)
{
    while (i <= resultA)
    {
        if (i % 2 == 0)
        {
            Console.Write(String.Join(",", i));
            i++;
        }
        else 
        {
            i++;
        }
    }
}
else
{
    int n = -1;
    while (n >= resultA)
        if (n % 2 == 0)
        {
            Console.Write(n);
            n--;
        }
        else
        {
            {
                n--;
            }
        }
}