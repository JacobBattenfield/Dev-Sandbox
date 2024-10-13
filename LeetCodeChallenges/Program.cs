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
        //Testcase 2
        Console.WriteLine();
        Console.WriteLine("Is N Prime?:");
        Console.WriteLine("++++++++++++++++++++++++++++");
        Console.WriteLine(Problems.IsPrime(3));
        Console.WriteLine(Problems.IsPrime(15));
        Console.WriteLine(Problems.IsPrime(1));
        Console.WriteLine("++++++++++++++++++++++++++++");

        //Testcase 3
        Console.WriteLine();
        Console.WriteLine("Sum Of Digits:");
        Console.WriteLine("++++++++++++++++++++++++++++");
        Console.WriteLine(Problems.SumOfDigits(33));
        Console.WriteLine(Problems.SumOfDigits(11111111));
        Console.WriteLine(Problems.SumOfDigits(32485));
        Console.WriteLine("++++++++++++++++++++++++++++");

        //Testcase 4
        Console.WriteLine();
        Console.WriteLine("Numeric Palindrome:");
        Console.WriteLine("++++++++++++++++++++++++++++");
        Console.WriteLine(Problems.NumericPalindrome(303));
        Console.WriteLine(Problems.NumericPalindrome(11111111));
        Console.WriteLine(Problems.NumericPalindrome(32485));
        Console.WriteLine("++++++++++++++++++++++++++++");

        //Testcase 5
        Console.WriteLine();
        Console.WriteLine("2nd Largest Number:");
        Console.WriteLine("++++++++++++++++++++++++++++");
        Console.WriteLine(Problems.SecondLargestNum([399,54324,545345,3224,34234324,9])); //expected 545345
        Console.WriteLine(Problems.SecondLargestNum([8,3,4,5,2,3,52,353])); //expected 52
        Console.WriteLine(Problems.SecondLargestNum([1,2,3,4,5,6,7,8])); //expected 7
        Console.WriteLine("++++++++++++++++++++++++++++");

        //Testcase 6
        Console.WriteLine();
        Console.WriteLine("Delete Duplicates:");
        Console.WriteLine("++++++++++++++++++++++++++++");
        Console.WriteLine(string.Join(" ",Problems.DeleteDuplicates([399,54324,34234324,34234324,34234324,545345,3224,34234324,9])));
        Console.WriteLine(string.Join(" ",Problems.DeleteDuplicates([8,3,4,5,2,3,53,53,53,53,53,53,35,53,53,45,52,353])));
        Console.WriteLine(string.Join(" ",Problems.DeleteDuplicates([1,1,2,2,3,3,4,4,5,5,6,6])));
        Console.WriteLine("++++++++++++++++++++++++++++");

        //Testcase 7
        Console.WriteLine();
        Console.WriteLine("CountVowels:");
        Console.WriteLine("++++++++++++++++++++++++++++");
        Console.WriteLine(string.Join(" ",Problems.NumOfVowelsAndConsonants("Heyyy how are you today?!")));
        Console.WriteLine(string.Join(" ",Problems.NumOfVowelsAndConsonants("What is up you silly silly guy")));
        Console.WriteLine(string.Join(" ",Problems.NumOfVowelsAndConsonants("The hippo once told me to be very quiet.")));
        Console.WriteLine("++++++++++++++++++++++++++++");
         //Testcase 8
        Console.WriteLine();
        Console.WriteLine("Reddit Halfed Button Press:");
        Console.WriteLine("++++++++++++++++++++++++++++");
        Console.WriteLine(Problems.HalfedButtonPressChanceOfNothing(1));
        Console.WriteLine(Problems.HalfedButtonPressChanceOfNothing(10));
        Console.WriteLine(Problems.HalfedButtonPressChanceOfNothing(100));
        Console.WriteLine(Problems.HalfedButtonPressChanceOfNothing(1000));
        Console.WriteLine(Problems.HalfedButtonPressChanceOfNothing(100000000));
        Console.WriteLine("++++++++++++++++++++++++++++");
    }
}