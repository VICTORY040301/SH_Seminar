// программа которая принимает на входе два целых числа и проверяте является ли второе число квадратом первого.
// a = 25; b = 5 - yes
// a = 2; b = 10 - no
// a = 9; b = -3 - yes
// a = -3; b = 9 - no

int firstValue = int.Parse(Console.ReadLine());
int secondValue = Convert.ToInt32(Console.ReadLine());

if(firstValue == secondValue * secondValue)
{
     Console.WriteLine($"yes, a = {firstValue}, b = {secondValue}");
}
else
{
     Console.WriteLine("a = " + firstValue + ", b = " + secondValue + " no");
}