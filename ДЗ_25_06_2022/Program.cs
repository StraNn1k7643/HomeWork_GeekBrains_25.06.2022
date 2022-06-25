//ДЗ задача№2
Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if ( number1 > number2 )
 {
     Console.WriteLine("Первое число больше второго") ;
 }
 else
 {
     Console.WriteLine("Второе число больше первого") ;
 }







// ДЗ задача№4
Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if ( number1 > max ) max = number1;
if (number2 > max ) max = number2;
if (number3 > max) max = number3;
Console.Write("max = ");
Console.Write(max);










//ДЗ задача №6
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.Write("Число чётное");
}
else
{
    Console.Write("Число не чётное");
}






//Задача№8
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
    
for (int i = 1; i <= N; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);
   
     





