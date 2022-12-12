/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 
*/

Console.Clear();

Console.Write("Enter K1 in y = k1 * x + b1: ");
string getString = Console.ReadLine() ?? String.Empty;
int k1 = CheckInput(getString);

Console.Write("Enter B1 in y = k1 * x + b1: ");
getString = Console.ReadLine() ?? String.Empty;
int b1 = CheckInput(getString);

Console.Write("Enter K2 in y = k2 * x + b2: ");
getString = Console.ReadLine() ?? String.Empty;
int k2 = CheckInput(getString);

if (k1 == k2) {
    Console.WriteLine("K1 = K2, so the lines are not intersected!");
    Console.WriteLine("Enter new K2 or type 'Q':");  
    while (true) {
        getString = Console.ReadLine() ?? String.Empty;
        k2 = CheckInput(getString);
        if (k1 != k2) break;
        Console.Write("Stop it! They are still equal! Enter new K2!");
    }
}

Console.Write("Enter B2 in y = k2 * x + b2: ");
getString = Console.ReadLine() ?? String.Empty;
int b2 = CheckInput(getString);

double X = Math.Round((double)(b2 - b1)/(k1 - k2), 2);
double Y = Math.Round((double) k2 * X + b2, 2);

Console.WriteLine($"\nThe point of intersection of two straight lines:\ny = {k1} * x + {b1} and y = {k2} * x + {b2} is (" + X + "," + Y + ")");


int CheckInput (string get_num) {
    while (true) {
        if (get_num == "Q") Environment.Exit(0);
        if (int.TryParse(get_num, out int num)) return num;
        else {
            Console.Write("This is not an integer! Try again or type 'Q': ");
            get_num = Console.ReadLine() ?? String.Empty;
        }
    }
}