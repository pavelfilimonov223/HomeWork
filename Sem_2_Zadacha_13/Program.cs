// Задача № 13. Вводим любое число. Выводим третью цифру или сообщение,
// что третьей цифры нет.
System.Console.Write("Введите любое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a>99 && a<1000)
{
    System.Console.WriteLine($"{a}->{a%10}");
} else if(a<99)
{
    System.Console.Write($"{a}-> Третьей цифры нет !");
} else if(a>999)
{
   System.Console.Write($"{a}-> Не знаю решения на этот случай!"); 
}
