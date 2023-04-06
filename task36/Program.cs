/*** Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
Console.Clear();
int [] arrayrandom (int size, int min, int max){
    int [] array = new int[size];
    for (int i = 0; i<size; i++)
    {array[i]= new Random().Next(min,max);}
    return array;
}
int []res = arrayrandom(10, -100, 100);
int sum (){
    int n = 0;
    for (int i=1; i<res.Length; i+=2)
    {n += res[i];}
    return n;
}
Console.WriteLine($" [ {string.Join(", ",res)} ] -> {sum()}");