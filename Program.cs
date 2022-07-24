void FillArray(double[,] array,int rows, int colums, string type){
    Random random = new Random();
    int maxValue = 100;
    int minValue = -100;
    for (int i=0; i<rows; i++){
        for (int j=0; j<colums; j++){
            if (type == "int") array[i,j] = random.Next(minValue, maxValue);
            else array[i,j] = random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
}
void PrintArray(double[,] array,int rows, int colums){
    for (int i=0; i<rows; i++){
        for (int j=0; j<colums; j++){
            Console.Write(Math.Round(array[i,j],1) + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void dz47(){
    Console.WriteLine("Задача 47");
    int rows = 3;
    int colums = 6;

    double [,] array = new double[rows,colums];
    FillArray(array,rows,colums,"double");
    PrintArray(array,rows,colums);
}
dz47();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void dz50(){
    Console.WriteLine("Задача 50");
    int rows = 3;
    int colums = 6;

    double [,] array = new double[rows,colums];
    FillArray(array,rows,colums,"int");
    PrintArray(array,rows,colums);

    Console.Write("Введите позицию в строке:");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите позицию в колонке:");
    int j = Convert.ToInt32(Console.ReadLine());

    if (i>rows || j >colums) Console.WriteLine("Элемент не найден");
    else Console.WriteLine(Math.Round(array[i-1,j-1],1));
    Console.WriteLine();
}
dz50();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void dz52(){
    Console.WriteLine("Задача 52");
    int rows = 3;
    int colums = 3;
    
    double [,] array = new double[rows,colums];
    FillArray(array,rows,colums,"int");
    PrintArray(array,rows,colums);
    Average(array,rows,colums);
}

void Average(double[,] array,int rows, int colums){
    double sum = 0;
    for (int i=0; i<rows; i++){
        for (int j=0; j<colums; j++){
            sum += array[i,j];
        }
        Console.WriteLine($"Среднее арифмитическое {i+1} строки = {Math.Round(sum/colums,1)}");
    }
}
dz52();