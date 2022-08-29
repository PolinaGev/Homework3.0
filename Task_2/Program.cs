double GetRange(int xa, int ya, int xb, int yb, int za, int zb)
{
double gfew = Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2);
return Math.Sqrt(gfew);
}

System.Console.WriteLine(GetRange(3, 6, 2, 1, 8, -7));
