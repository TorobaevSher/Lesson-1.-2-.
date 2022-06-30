//Напишите программу, которая на вход принимает
// два числа и выдает, какое число больше,
// а кокое меньшее.

Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());

 if(first > second)Console.WriteLine(first);   
else Console.WriteLine(second);