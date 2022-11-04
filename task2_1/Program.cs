// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int input = Convert.ToInt32(Console.ReadLine());
bool result = CheckNum(input);
if (result == false)
{
    Console.WriteLine("Ошибка! Число не трехзначное!");
}
else
{
    int second = GetThirdNum(input);
    Console.WriteLine($"Второе число {second}");
}

int GetThirdNum(int number)
{
    int res = number % 100 / 10;
    return res;
}

bool CheckNum(int num)
{
    return num < 1000 && num > 99;
}
