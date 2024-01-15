// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

int sum = 0;
for(int i = 1; i < 101; i++)
{
    sum = 0;
    for (int j = 1; j < i+1; j++)
    {
        if (i % j == 0)
        {
            sum += 1;
        }
    }
    if (sum == 2)
    {
        Console.WriteLine(i);

    }
}
