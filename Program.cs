// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
//  натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

// int m = 3;
// int n = 4;
// string PrintNumbers (int a, int b)
// {
//     if(a == b) return b.ToString();
//     return (a + ", " + PrintNumbers(a + 1, b));

// }
// Console.WriteLine(PrintNumbers(m,n));



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int m = 2;
// int n = 5;
// int SummNumbers(int start, int end)
// {
//     if (start == end) return end;
//     return start + SummNumbers(start + 1, end);
// }
// Console.WriteLine(SummNumbers(m, n));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = , n = 3 -> A(m,n) = 29

// int m = 3;
// int n = 8;
// int Akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (m > 0 && n == 0) return Akkerman(m - 1, 1);
//     return Akkerman(m - 1, Akkerman(m, n - 1));
// }
// Console.WriteLine(Akkerman(m, n));

