// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

void NTo1(int num){
    Console.Write($"{num} ");
 
 
    if (num > 1) NTo1(num-1);
}
// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int sumOfMToN( int N, int M){
    if (N == M) return M;
    else return N + sumOfMToN(N-1, M);
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int accerman(int m, int n){
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return accerman(m - 1, 1);
    else return accerman(m - 1, accerman(m, n - 1));
}

Console.Write("Task 1: ");
NTo1(8);
Console.WriteLine();

Console.Write("Task 2: ");
Console.WriteLine($"{sumOfMToN(5, 1)}");

Console.Write("Task 3: ");
Console.WriteLine(accerman(3, 2));