// Задача 12. На вход второе числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1 то прога выводит остаток от деления
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
if (n % m ==0)      // если остаток при дилении первого на второе равен 0 то yes 
    Console.WriteLine("yes"); 
else
    Console.WriteLine($"no, ostatok {n % m}");