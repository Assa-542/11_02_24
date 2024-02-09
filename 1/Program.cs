int M = 4;
int N = 8;

void RecursivePrintNumbers(int start, int end)
{
    if (start > end)
    {
        Console.WriteLine("");
        return;
    }
    Console.Write(start);
    RecursivePrintNumbers(start + 1, end);
}
RecursivePrintNumbers(M, N);