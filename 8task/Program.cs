
Console.Write("Enter number ");

int num1 = Convert.ToInt32(Console.ReadLine());

byte num = 1;
            while (num <= num1)
            {
                int result = num % 2;
                if (result != 1)
                {
                    Console.WriteLine("четное " + num);
                    num++;
                }
                else
                {
                    num++;
                }
            }
