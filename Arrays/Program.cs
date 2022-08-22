using System;
using System.IO;
using System.Reflection;


internal class Program
{
    private static void Main(string[] args)
    {

        int[,,] a = new int[2,2,2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for(int k = 0; k < 2; k++)
                {
                    a[i,j,k] = (i+j+k)*10;
                }
            }
        }
        //Array.BinarySearch
        Console.WriteLine("ELEMENTS:\n");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for(int k = 0; k < 2; k++)
                {
                    Console.WriteLine("A[{0}][{1}][{2}] = {3}", i,j,k, a[i,j,k]);
                }
            }
        }
    }
}