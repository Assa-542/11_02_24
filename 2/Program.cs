void ShowNumbers (int m, int n)
{
    if (m != n+1)
{
    if (m%2==0)
    {
Console.Write($"{m}");
    }
    ShowNumbers (m+1, n);
}
}
ShowNumbers(5,9);