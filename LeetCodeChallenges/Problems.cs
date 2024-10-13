using System.Security.Cryptography;

class Problems{

    public static int NthFibNum(int n){
        if(n==0){
            return 0;
        }
        int cur = 1;
        int prev = 0;
        for(var i = +1;i<n;i++){
            int temp = cur+prev;
            prev = cur;
            cur = temp;
        }
        return cur;
    }
    //returns true if it is a prime number and returns false if it is not a prime number
    public static bool IsPrime(int n){
        if(n==0||n==1){
            return false;
        }
        for(int i = 2;i<n;i++){
            if(n%i==0){
                return false;
            }
        }
    return true;
    }

    public static int SumOfDigits(int n){
        string SplitN = Convert.ToString(n);
        char[] charArray = SplitN.ToCharArray();
        int[] numArray = new int[charArray.Length];
        for(int i = 0;i<charArray.Length;i++){
            numArray[i] = Convert.ToInt32(charArray[i])-Convert.ToInt32('0');
        }
        int total = 0;
        for(int i = 0;i<numArray.Length;i++){
            total+=numArray[i];
        }
        return total;
    }

    public static bool NumericPalindrome(int n){
        string number = Convert.ToString(n);
        string reverseNumber = "";
        for (int i = number.Length - 1; i >= 0 ; i--){
            reverseNumber+=number[i];
        }
        if(reverseNumber==number){
            return true;
        }
        return false;
    }

    public static int SecondLargestNum(int[] nums){
        int maxValue = 0;
        for(int i = 0;i<nums.Length;i++){
            if(nums[i]>maxValue){
                maxValue=nums[i];
            }
        }
        int secondMax = 0;
        for(int i = 0;i<nums.Length;i++){
            if(nums[i]>secondMax && nums[i]!=maxValue){
                secondMax=nums[i];
            }
        }
        return secondMax;
    }
    //[1,2,3,4,4,4,4,5,6,7,8]
    public static int[] DeleteDuplicates(int[] nums){
        List<int> newArray = [];
        HashSet<int> seenNumbers = [];
        for(int i = 0;i<nums.Length;i++){
            if(!seenNumbers.Contains(nums[i])){
                newArray.Add(nums[i]);
            }
            seenNumbers.Add(nums[i]);
        }
        return [.. newArray];
    }

    public static int[] NumOfVowelsAndConsonants(string input){
        string vowels = "aeiouAEIOU";
        int vowelNum = 0;
        int consNum = 0;

        foreach(char letter in input){
            if(char.IsLetter(letter)){
                if(vowels.Contains(letter)){
                    vowelNum++;
                }else if(!vowels.Contains(letter)){
                consNum++;
                }
            }
        }
        return [vowelNum,consNum];
    }

    public static string HalfedButtonPressChanceOfNothing(int NumPresses){
        int Money = 0;
        double chances = 0.5;
        Random rand = new();
        for(int i = 0;i<NumPresses;i++){
            if(rand.NextDouble()<chances){
                Money+=1000000;
            }
            chances /= 2;
        }
        return $"You pressed the button {NumPresses} times and you won ${Money}!! The chances of winning any more money after {NumPresses} is {Math.Round(chances*100,2)}%";
    }
}