// Задача. Принимает на вход цифру - день недели, проверяет выходной ли этот день.
System.Console.Write("Введите номер дня недели: ");
int dnum = Convert.ToInt32(Console.ReadLine());
if(dnum >= 1 && dnum <= 5)
{
    Console.WriteLine($"{dnum} -> НЕТ, иди работай !");
} else if(dnum >= 6 && dnum <= 7)
{
   Console.WriteLine($"{dnum} -> ДА, это выходной"); 
} else 
{
    Console.WriteLine($"{dnum} -> Ошибка, в неделе только 7 дней !");
}
