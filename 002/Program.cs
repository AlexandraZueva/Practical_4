// Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную степень B.
int C = 1;
Console.WriteLine("Enter A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B");
int B = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= B && B > 0; i++)
{
    C = C * A;
}
Console.WriteLine(C);