//Найти сумму чисел от 1 до А

int S = 0;
Console.WriteLine("Enter A");
int A = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= A; i++)
{   
    S = S + i;
}
Console.WriteLine(S);