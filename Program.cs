/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
(Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)

3, 5 -> 243 (3⁵)
2, 4 -> 16*/

/*Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiate(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
        return result;
}

  int exponentiation = Exponentiate(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12  */


/*Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberA)
  {
    int count = Convert.ToString(numberA).Length;
    int remainder = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      remainder = numberA - numberA % 10;
      result = result + (numberA - remainder);
      numberA = numberA / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberA);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);*/


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)*/

int[] Array = GetArray(8); 
Console.Write($"[{String.Join(";", Array)}]"); 
 
int[] GetArray (int size) 
{ 
    int[] Array = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
        Array[i] = new Random().Next(100); 
    } 
    return Array; 
}

