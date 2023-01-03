using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        int[] arr=new int[5];
        for(int i=0;i<5;i++)
        {
            System.Console.WriteLine("Enter a number");
            arr[i]=int.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("Before Sorting");
        for(int i=0;i<5;i++)
        {
            
            System.Console.Write(arr[i]+" ");
        }
        System.Console.WriteLine();
        System.Console.WriteLine("After Sorting");
        for(int i=0;i<arr.Length;i++)
        {
            for(int j=1;j<arr.Length-i;j++)
            {
                if(arr[j]<arr[j-1])
                {
                    int temp=arr[j];
                    arr[j]=arr[j-1];
                    arr[j-1]=temp;
                }
            }
        }
        for(int i=0;i<5;i++)
        {
            System.Console.Write(arr[i]+" ");
        }


    }
}