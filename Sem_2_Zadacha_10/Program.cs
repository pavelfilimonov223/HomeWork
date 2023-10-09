// Задача. На вход трехзначное число, на вывод показать вторую цифру числа.

System.Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a>99 && a<1000)
{
    System.Console.WriteLine($"{a}->{(a%100-a%10)/10}");
} else
{
    System.Console.Write("Это число не является трехзначным !");
}
