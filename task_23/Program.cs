//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// кубов чисел от 1 до N.3 -> 1, 8, 27. 5 -> 1, 8, 27, 64, 125
    void Cube(int number)
    {
      int countdown = 1;
      int index = 0;
      while (index < number)
      {
        Console.Write(Math.Pow(countdown,3) + "  ");
        index++;
        countdown++;
      }
    }
Console.WriteLine("Введите N  ");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);
Console.WriteLine();