// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
bool Palindrom(string number)
{
    int index = number.Length;
    if (index == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
        {
            Console.WriteLine(" Палиндром ");
            return true;
        }
        else
        {
            Console.WriteLine(" Не палиндром ");
            return false;
        }
        return true;
    }
    else
    {
       Console.WriteLine("Это не 5-ти значное число: "); 
    }
    return false;
}

Console.WriteLine("Введите 5-ти значное число: ");
string number = Console.ReadLine();

bool result = Palindrom(number);
Console.WriteLine(result);