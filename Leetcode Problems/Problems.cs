class Problems{
    //Description: "Write a function that displays the "Nth" Fibonacci number

    //uses a temporary value "temp" to store the addition for the nex round of the loop. therefore printing the fibanaci number at that location
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
}