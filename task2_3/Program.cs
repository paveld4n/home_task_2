// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");
int input = Convert.ToInt32(Console.ReadLine());
bool result = CheckNum(input);
if (result == false)
{
    Console.WriteLine("Это не выходной!");
}
else
{
       Console.WriteLine("Ура!! Выходной");
}



bool CheckNum(int num)
{
    return num < 8 && num > 5;
}

