//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите трехзначное натуральное число");
int enter = Convert.ToInt32(Console.ReadLine());
if(enter < 100)
{
    Console.WriteLine("Ошибка! Число не сооотвествует требованиям!");
}
else
    {
    int third = GetThirdNum(enter);
    Console.WriteLine($"Третья цифра = {third}");
    }


int GetLengtNum(int num)
{
    int count = 0;
    while(num > 0)
    {
        num /= 10;
        count++;
    }
    return count;

}

int GetThirdNum(int input)
{
    int lenght = GetLengtNum(input);
    int[] array = new int[lenght];

    for (int i = lenght - 1; i > 0; i--)
    {
        array[i] = input % 10;
        input /= 10;  
    }
    // int none = (array[0]);
    // Console.WriteLine($"Первая цифра = {none}");
    
    int res = (array[2]);
    return res;
    
}

