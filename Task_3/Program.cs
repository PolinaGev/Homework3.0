void Cube (int number)
{
    for (int i = 1; i <= number; i++)
    {
    if (i >= number)
    {
        System.Console.Write(Math.Pow(i, 3) + ".");
    }
    else
    {
        System.Console.Write(Math.Pow(i, 3) + ", ");
    }
    }
}

Cube(5);