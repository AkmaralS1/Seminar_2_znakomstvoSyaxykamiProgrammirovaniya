// Задача пользователь передает 2 числа и говорит что не равны нужно вывести сообщ какое число больше
String f(int a, int b)
{
    if (a > b)
        return ">";

    return " < ";
}
Console.WriteLine(f(10, 29));
