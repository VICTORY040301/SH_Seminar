// Программа, которая на входе принимает одно целое число N, 
// а на выходе показывает все целые значения между N и -N.

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = -number;
while(i <= number)
{
    System.Console.Write(i + " ");
    i++;
}

// for(int i = -number; i <= number; i++)
//    System.Console.Write(i + " ");
