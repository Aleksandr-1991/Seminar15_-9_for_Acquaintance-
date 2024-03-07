// №67. Прога принимает на вход число и возвращает сумму его цифр.
// 1 вар (со счётчиком действий): 
/*
void SumOfDigits(int number, int sum, int i) {
    if (number != 0) {
        sum += number % 10;
        number /= 10;
        i++;
        System.Console.WriteLine($"На шаге {i} сумма равна: {sum}");
        SumOfDigits(number, sum, i);
    }
}
int Promt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int number = Promt("Введите целое число: ");
int sum = 0;
int i = 0;
SumOfDigits(number, sum, i);      //*/

// 2 вар: /*
int SumOfDigits(int number, int sum)
{
    if (number != 0)
    {
        sum += number % 10;
        number /= 10;
        return SumOfDigits(number, sum);
    }
    return sum;
}
int Promt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}
int number = Promt("Введите целое число: ");
int sum = 0;
Console.Write($"Сумма цифр в числе равна: {SumOfDigits(number, sum)}");      //*/