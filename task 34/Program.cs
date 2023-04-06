/*** Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
Console.Clear();
int [] arrayrandom (int size, int min, int max){
    int [] array = new int[size];
    for (int i = 0; i<size; i++)
    {array[i]= new Random().Next(min,max);}
    return array;
}
int [] res = arrayrandom(10, 100, 1000); 
int num (){
    int n = 0;
    for (int i = 0; i<res.Length;i++)
    {
        if (res[i]%2 == 0)
    n++;
    }
    return n;
}
Console.WriteLine($"[ {string.Join(", ",res )} ] -> {num ()}");