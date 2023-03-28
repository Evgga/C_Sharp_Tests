// Задача 10. Напишите программу, ктр принимает на вход целое число любой разрядности и 
//на выходе показывает вторую цифру слева этого числа.

Console.Write("Введите число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Вторая цифра этого числа -> "+stringNumber[1]);
