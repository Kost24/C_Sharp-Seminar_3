
// Задача 2: 

// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет 
// количество чётных чисел в массиве.


int n = 10;
int[] array = {22, 51, 74, 8, 76, 1, 4, 35, 84, 9};
int i = 0;
int count = 0;

while(i < n)
{
    if(array[i] % 2 == 0)
    {
        count = count + 1;
        // Console.Write(count);
    }
    i = i +1;
}
Console.Write(count);