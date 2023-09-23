// Вывести на экран большее из трех значений

int a, b, c;
Console.WriteLine("Введите 1-е число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число");
c = Convert.ToInt32(Console.ReadLine());
if ((a>b) && (a>c));
{
    Console.WriteLine("наибольшее число = ",a);
}
else if ((b>a) && (b>c));
{
    Console.WriteLine("наибольшее число = ",b);
}
else if ((c>a) && (c>b));
{
    Console.WriteLine("наибольшее число = ",c);
}
