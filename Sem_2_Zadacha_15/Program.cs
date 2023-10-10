// Задача. Принимает на вход цифру, день недели, проверяет выходной ли этот день.

System.Console.Write("Введите номер дня недели: ");
int dnum = Convert.ToInt32(Console.ReadLine());
if (dnum == 1)
{
    Console.WriteLine($"{dnum} -> НЕТ");
} else if (dnum ==2)
{
    Console.WriteLine($"{dnum} -> НЕТ");
} else if (dnum ==3)
{
   Console.WriteLine($"{dnum} -> НЕТ"); 
} else if (dnum ==4)
{
    Console.WriteLine($"{dnum} -> НЕТ");
} else if (dnum ==5)
{
    Console.WriteLine($"{dnum} -> НЕТ");
} else if (dnum ==6)
{
    Console.WriteLine($"{dnum} -> ДА, это выходной");
} else if (dnum ==7)
{
    Console.WriteLine($"{dnum} -> ДА, это выходной");
} else
{
    Console.WriteLine($"{dnum} -> Ошибка ввода, надо от 1 до 7 дней в неделе");
}
