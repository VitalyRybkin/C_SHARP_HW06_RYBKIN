/*
Дополнительная задача 2 (задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов, 
которые необходимо заполнить случайными значениями и определить существует ли пара соседних элементов с одинаковыми значениями, 
при наличии такого элемента заменить его на уникакальное значение.

[1,2,3,3] -> [1,2,3,4]
*/

using System;

Console.Clear();

Console.Write("Enter an array size: ");
string getString = Console.ReadLine() ?? String.Empty;
Random rdm = new Random();
int arraySize = CheckInput (getString);
int [] arrayNums = new int[arraySize];
int numsUpperLimit = 10;
arrayNums = FillArray(arraySize, arrayNums, rdm, numsUpperLimit);
string posChanged = String.Empty;


Console.Write("\nArray to check: ");
foreach (int item in arrayNums) Console.Write(item + " ");
Console.WriteLine();

// Из условия задачи не совсем понятна формулировка "уникальное значение": уникальное для всего массива или просто отличное от предыдущего?
// В данном коде рассмотрен пример уникального значения для всего массива.
// Для того, чтобы уникальное значение всегда существовало переменная numsUpperLimit используется в Random() и 2 * numsUpperLimit
// при поиске уникального значения в методе FindUniqueNum. В противном случае при определенном размере массива уникального значения может не быть.

numsUpperLimit *= 2;
for (int i = 0; i < arrayNums.Length - 1; i ++) {
    if (arrayNums[i] == arrayNums[i + 1]) {
        arrayNums[i + 1] = FindUniqueNum(arrayNums, numsUpperLimit);
        posChanged += "\n" + "Pos. " + (i + 2) + ": " + arrayNums[i] + " -> " + arrayNums[i + 1];
    }
}

Console.Write("Array with chages: ");
foreach (int item in arrayNums) Console.Write(item + " ");
Console.WriteLine();
if (String.IsNullOrEmpty(posChanged)) Console.WriteLine("Nothing was changed!");
else Console.WriteLine("\nPositions changed: " + posChanged);

int FindUniqueNum (int[] arr, int upperLimit) {
        int uniqueVal = 0;
        for (int i = 1; i < arr.Length; i ++) {
            if (!arr.Contains(i)) {
                uniqueVal = i;
            }
        }
        return uniqueVal;
}


int CheckInput (string get_size) {
    while (true) {
        if (get_size == "Q") Environment.Exit(0);
        if (int.TryParse(get_size, out int num)) return num;
        else {
            Console.Write("This is not an integer! Try again or type 'Q': ");
            get_size = Console.ReadLine() ?? String.Empty;
        }
    }
}

int[] FillArray (int size, int[] arr, Random rdm, int numsUpperLimit) {
    for (int i = 0; i < arr.Length; i ++) arr[i] = rdm.Next(1, numsUpperLimit);
    return arr;
}