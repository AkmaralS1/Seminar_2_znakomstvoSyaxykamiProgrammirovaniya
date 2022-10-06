// пример вывода массива в терминал

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
        array [i] = new Random().Next(-10, 11);

Console.WriteLine("[" + string.Join(", ", array) + "]");   

// Вывод можно написать по другому: 
Console.WriteLine($"[{string.Join(", ", array)}]");