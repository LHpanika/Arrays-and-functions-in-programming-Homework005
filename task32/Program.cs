// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами 
// из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.
int [] array = new int [12];
Random rand = new Random();
for (int i = 0; i<array.Length; i++)
{
    array[i] = rand.Next(-9,10); 
    
}
Console.WriteLine(string.Join(", ", array));

for (int i = 0; i<array.Length; i++)
{
    array[i] *= -1; 
    
}
Console.WriteLine(string.Join(", ", array));
