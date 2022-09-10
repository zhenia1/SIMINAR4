//Задача 25: Напишите цикл,который принимает на вход два числа (А и В) и возводит число А в натуральную степинь В.
// 3, 5 -> 243  (3⁵)
// 2, 4 -> 16

Console.WriteLine($"\nЗадача 25. Возведене числа A в натуральную степень B");

int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("Ответ: " + exponentiation);
