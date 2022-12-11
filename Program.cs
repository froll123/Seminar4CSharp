/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
(Math.Pow использовать нельзя!!!)
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


int num_a, num_b;

            Console.WriteLine("Для формулы a^b");
            Console.Write("Введите число a: ");
            num_a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b: ");
            num_b = Convert.ToInt32(Console.ReadLine());

            int res = 1;
            res = num_a;
            for (int i = 2; i <= num_b; i++)
            {
                res *= num_a;
            }

            Console.WriteLine($"{num_a}^{num_b} = {res}");
            


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
сумму цифр в числе.(Массивы и строки использовать нельзя!!!)
452 -> 11
82 -> 10
9012 -> 12*/

int num_c;
            Console.Write("Введите любое число: ");
            num_c = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            while (num_c != 0)
            {
                result += num_c % 10;
                num_c /= 10;
            }

            Console.WriteLine($"Сумма цифр в числе = {result}");


/*Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,50);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

