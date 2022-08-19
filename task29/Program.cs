// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] ;   6, 1, 33 -> [6, 1, 33]
Console.Clear();
// Console.WriteLine("Введите восьмизначное число");
// int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[8];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0,100);
}
Console.WriteLine('[' + string.Join(",", array) + ']');
