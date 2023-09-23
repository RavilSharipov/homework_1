// Вывести на экрна болшее из двух значений
using System.ComponentModel.DataAnnotations;

int a, b;
Console.WriteLine("Введите 1-е число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
Console.WriteLine("Наибольшее число");
Console.Write(a);
} 
else{
    Console.WriteLine("Наибольшее число");
    Console.Write(b);
}
