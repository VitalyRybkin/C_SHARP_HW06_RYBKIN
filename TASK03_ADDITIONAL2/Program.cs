/*
Дополнительная задача (задача со звёздочкой): 
Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями 
и сдвинуть элементы массива влево, или вправо на 1 позицию.

[8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
[8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо
*/

using System;

Console.Clear();

Console.Write("Enter an array size: ");
string getString = Console.ReadLine() ?? string.Empty;
int arraySize = CheckInput(getString);
int[] arrayNums = new int[arraySize];
arrayNums = FillArray(arraySize, arrayNums);
string whatToPrint = String.Empty;

PrintArray (arrayNums, arraySize, whatToPrint = "Original");

for (int i = arrayNums.Length - 1; i > 0; i --) (arrayNums[i], arrayNums[i - 1]) = (arrayNums[i - 1], arrayNums[i]);
PrintArray (arrayNums, arraySize, whatToPrint = "Right-shifted");

for (int i = 0; i < arrayNums.Length - 1; i ++) (arrayNums[i], arrayNums[i + 1]) = (arrayNums[i + 1], arrayNums[i]);
PrintArray (arrayNums, arraySize, whatToPrint = "Left-shifted");

void PrintArray (int[] arr, int size, string whatToPrint) {
    Console.Write($"{whatToPrint} array: ");
    foreach (int item in arrayNums) Console.Write(item + " ");
    Console.WriteLine();
}

int [] FillArray(int arraySize, int[] arr) {
    Random rndm = new Random();
    for (int i = 0; i < arraySize
; i++) arr[i] = rndm.Next(1, 10);
    return arr;
}

int CheckInput(string str) {
    while (true) {
        if (str == "Q") Environment.Exit(0);
        if (int.TryParse(str, out int num)){
                Console.Clear();
                return num;
        }
        else {
            Console.Write("\nThis is not an integer!");
            Console.Write(" Try again or type 'Q'!");
            str = Console.ReadLine() ?? String.Empty;
        }
    }
}
