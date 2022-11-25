// Напишите программу, которая на входе принимает два числа и выдаёт, какое число больше, а какое меньше.

Console.Clear();

Console.Write("Введите 1 число ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число ");

int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2)
    Console.WriteLine("Числа равны");
else if(num1 > num2)
    Console.WriteLine($"Большее число: {num1}");
else
    Console.WriteLine($"Большее число: {num2}");
    
    
    