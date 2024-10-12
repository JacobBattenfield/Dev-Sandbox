class Program{
    static void Main(){
    
        //Testcase 1
        Console.WriteLine();
        Console.WriteLine("Nth Fibonaci Number:");
        Console.WriteLine("++++++++++++++++++++++++++++");
        Console.WriteLine(Problems.NthFibNum(23));
        Console.WriteLine(Problems.NthFibNum(15));
        Console.WriteLine(Problems.NthFibNum(5));
        Console.WriteLine("++++++++++++++++++++++++++++");
        Console.WriteLine();
        //Testcase 2
        Console.WriteLine();
        Console.WriteLine("Is N Prime?:");
        Console.WriteLine("++++++++++++++++++++++++++++");
        Console.WriteLine(Problems.IsPrime(3));
        Console.WriteLine(Problems.IsPrime(15));
        Console.WriteLine(Problems.IsPrime(1));
        Console.WriteLine(Problems.IsPrime(5));
        Console.WriteLine("++++++++++++++++++++++++++++");
        Console.WriteLine();

        //Testcase 3
        Console.WriteLine();
        Console.WriteLine("Sum Of Digits:");
        Console.WriteLine("++++++++++++++++++++++++++++");
        Console.WriteLine(Problems.SumOfDigits(33));
        Console.WriteLine(Problems.SumOfDigits(11111111));
        Console.WriteLine(Problems.SumOfDigits(32485));
        Console.WriteLine("++++++++++++++++++++++++++++");
        Console.WriteLine();
    }
}