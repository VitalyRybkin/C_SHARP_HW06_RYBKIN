/*
Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();
int countPosNums = 0;

Console.Write("Enter some numbers using , or . or a space bar as separator and press ENTER: ");
string getString = Console.ReadLine() ?? String.Empty;
string newString = String.Empty;
bool isNotDigit = false;

for (int i = 0; i < getString.Length; i ++) {
    if (int.TryParse(getString[i].ToString(), out int num)) {
        newString += num.ToString();
        isNotDigit = true;
    }
    else {
        if (isNotDigit) {
            newString += ", ";
            isNotDigit = false;
        }
    }
    if (getString[i].ToString() == "-") newString += getString[i];
}

Console.WriteLine();
Console.Write("You've entered: " + newString);
Console.WriteLine();

string[] result = newString.Split(", ");

foreach (string item in result) {
    if (int.TryParse(item, out int num)) if (num > 0) countPosNums ++;
}

Console.WriteLine("Number of positive nums in your input is " + countPosNums);

