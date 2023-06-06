// Задача 68: 

// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void Main()
{
    int m = ReadInt("Enter avalue of m: ");
    int n = ReadInt("Enter avalue of n: ");
    System.Console.WriteLine("Result of Accerman's function: " + Ackermann(m, n));
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Ackermann(int M, int N)
{
    if (M > 0 && N > 0) return Ackermann(M - 1, Ackermann(M, N - 1));
    if (M > 0 && N == 0) return Ackermann(M - 1, 1); 
    if (M == 0) return N + 1;
    return Ackermann(M, N);
}

Main();