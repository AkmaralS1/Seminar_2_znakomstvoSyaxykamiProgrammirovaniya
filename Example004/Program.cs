// Задача 9. Напишите прогу которая выдает случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
Console.Clear();
int n = new Random().Next(10, 100);
int n1 = n / 10; // чтобы найти первую цифру числа
int n2 = n % 10; // чтобы найти последнюю цифру числа
Console.WriteLine($"Сгенерированное число: {n}");

if (n1 > n2)
    Console.WriteLine(n1);
else if (n1 < n2)
    Console.WriteLine(n2);
else
    Console.WriteLine("=");