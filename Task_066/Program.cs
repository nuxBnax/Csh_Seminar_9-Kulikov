// Задача 66: 

// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void Main()
{
    int M = ReadInt("Enter avalue of M: ");
    int N = ReadInt("Enter avalue of N: ");
    System.Console.WriteLine("Sum of numbers from M to N: " + SumNumbers(M, N));
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int m, int n)
{
    if(n < m) return 0; 
    return m + SumNumbers(m+1, n); 
}

Main();