// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵); 2, 4 -> 16
Console.Clear();
int Degree(int A, int B)
{
    int result = 1;
    for(int i = 1; i <= B; i++)
    {
        result = result * A;                              
    }
        return result; 
}
Console.WriteLine("введите число A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write($"Результат работы программы = {Degree(numberA, numberB)}");
