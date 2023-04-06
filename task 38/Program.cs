/*** Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
Console.Clear();
double [] arrayrandom (int size, int min, int max){
    double [] array = new double[size];
    for (int i = 0; i<size; i++)
    {array[i]= (new Random().Next(min,max));}
    return array;
}
double [] res = arrayrandom(10, -50, 50);
double max (){
    double max = res[0];
    for (int i = 1; i<res.Length;i++)
    {
        if (res[i]>max)
    max=res[i];
    }
    return max;
}
double min (){
    double min = res[0];
    for (int i = 1; i<res.Length;i++)
    {
        if (res[i]<min)
    min=res[i];
    }
    return min;
}
double dif = (max()) - (min());
Console.WriteLine($"[ {string.Join(", ",res )} ] -> {dif}");