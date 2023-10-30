using System.Reflection.Metadata.Ecma335;

class Program {

    public static void Main()
    {
        Console.WriteLine(MyFunction(11));
    }
   static int MyFunction(int num)
    {
        int Sum = 0;
        for (int i = 0; i <= num; i++)
        {
            if (Sum < num)
            {
                Sum += i;
            }
            else
            {
                Sum -= i-1;
                break;
            }
        }
        return Sum;
    }
}
