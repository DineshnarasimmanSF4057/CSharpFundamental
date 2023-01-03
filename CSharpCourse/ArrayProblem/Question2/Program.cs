using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        int[] arr=new int[10];
        for(int i=0;i<10;i++)
        {
            System.Console.WriteLine("Enter a number");
            arr[i]=int.Parse(Console.ReadLine());
        }
        int[] even=new int[10];
        int[] odd=new int[10];
        int j=0,k=0;
        for(int i=0;i<10;i++)
        {
            if(arr[i]%2==0)
            {
                even[j]=arr[i];
                j++;
            }
            else
            {
                odd[k]=arr[i];
                k++;
            }
        }
        System.Console.WriteLine("Even Numbers");
        for(int i=0;i<even.Length;i++)
        {
            if(i<j)
            {
                System.Console.Write(even[i]+" ");
            }
            
        }
        System.Console.WriteLine();
        for(int i=odd.Length;i>=0;i--)
        {
            if(i<k)
            {
                System.Console.Write(odd[i]+" ");
            }
            
        }
    }
}