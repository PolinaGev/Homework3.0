// void Main()
//         {
//             int number = 0;
//             int oldValue = number;
//             int newValue = 0;
//             while (number > 0)
//             {
//                 int dig = number % 10;
//                 newValue = newValue * 10 + dig;
//                 number = number / 10;
//             }
//             if (newValue == oldValue)
//                 Console.WriteLine("Число является палиндромом");
//             else
//                 Console.WriteLine("Число не является палиндромом");
//         }
// Main();

void GetPolindrom(int number)
{
    int oldValue = number;
    int newValue = 0;
    while (number > 0)
    {
    int dig = number % 10;
    newValue = newValue * 10 + dig;
    number = number / 10;
    }
    if (newValue == oldValue)
    Console.WriteLine("Число является палиндромом");
    else
    Console.WriteLine("Число не является палиндромом");  
}
GetPolindrom(12321);