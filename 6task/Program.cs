// Напишите программу, которая на вод принимает число и выдаёт, является ли число чётным (Делится ли оно на 2 без остатка).

 Console.WriteLine("Enter number");
 
 int a = Convert.ToInt32(Console.Read());
                
if (a % 2 == 0) 
    Console.WriteLine("Четное");
    else Console.WriteLine("Нечетное");
    Console.ReadKey();