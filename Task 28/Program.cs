// напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
Console.Clear();    
int A = GetNumberFromUser("Введите целое число N: ", "Ошибка ввода!");
int sumNumbers = GetSumNumbers(A);
Console.Write($"{A} -> {sumNumbers}");

int GetSumNumbers(int number)
{
    int res = 1;

    for (int i = 1; i <= number; i++)
        res = res * i;


    return res;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}