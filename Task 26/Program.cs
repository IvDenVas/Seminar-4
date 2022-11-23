// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
int number = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int res = NumberOfDigits(number);
Console.WriteLine($"{res}");

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

int NumberOfDigits(int num)
{
    int count = 0;
    if (num == 0)
    {
       count++; 
    } 
    else
    {
        while(num != 0)
        {
            num = num / 10;
            count++;
        }
        
    }
    return count;
}