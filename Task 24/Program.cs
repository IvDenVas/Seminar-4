// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
Console.Clear();    
int A = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int sumNumbers = GetSumNumbers(A);
Console.Write($"{A} -> {sumNumbers}");
///////////////////////////////////////////////////////////////////////////////////////////////////////////////
int GetSumNumbers(int number)
{
    int sum = 0;

    for (int i = 1; i <= number; i++)
        sum += i;


    return sum;
}
///////////////////////////////////////////////////////////////////////////////////////////////////////////////
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);//без bool ниже сразу в скобки
        if (isCorrect) // isCorrect = True // if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////
