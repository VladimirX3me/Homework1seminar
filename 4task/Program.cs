// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел. 

Console.Clear();

Console.Write("Enter number a: ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number b: ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number c: ");

int num3 = Convert.ToInt32(Console.ReadLine());

 if (num1 > num2 && num1 > num3)
                    Console.WriteLine("Nubmer Max = " + num1); 
                else if (num2 > num3)
                    Console.WriteLine("Number Max = " + num2); 
                else
                    Console.WriteLine("Number Max = " + num3); 
 if (num1 == num2 && num2 == num3)
    Console.WriteLine("Числа равны");


