// Показывает все четные числа до числа N
int N, b;
Console.WriteLine("Введите число");
N = Convert.ToInt32(Console.ReadLine());
b = 0;
while(N > b)
{
    b = b + 1;
    if(b % 2 == 0)
    {
        Console.Write("Четное число:");
        Console.WriteLine(b);
    }
}
