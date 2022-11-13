/* Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Write("Введите натуральное число больше 0: ");
int NatNumber = int.Parse(Console.ReadLine());

void NaturalNumbers(int NatNumber)
{
    if (NatNumber < 0)
    {
        Console.WriteLine($"Введённое число {NatNumber} - не натуральное число.");
        return;
    }
    if (NatNumber == 0) return;
    Console.Write("{0}\t", NatNumber);
    NaturalNumbers(NatNumber - 1);
}

NaturalNumbers(NatNumber);