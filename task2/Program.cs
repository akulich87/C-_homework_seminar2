// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());

int number2 = number1 % 10;

Console.WriteLine(number2);