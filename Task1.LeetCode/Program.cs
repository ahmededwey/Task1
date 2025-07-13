namespace Task1.LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // palindromeString("race a car");
            Console.WriteLine(isPalindrome("race a car") ); 
        }
       
       static public bool isPalindrome(string s)
        {
            s = s.ToLower();
            bool flag=false;
            //remove all non-alphanumeric characters
            s = System.Text.RegularExpressions.Regex.Replace(s, @"[^a-z0-9]", "");

            //check if the string is a palindrome
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    flag = false;
                    
                }
               
            }
            return true;

        }

        public IList<string> FizzBuzz(int n)
        {
            var answer = new List<string>(n);
            for (int i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                    answer.Add("FizzBuzz");
                else if (i % 3 == 0)
                    answer.Add("Fizz");
                else if (i % 5 == 0)
                    answer.Add("Buzz");
                else
                    answer.Add(i.ToString());
            }
            return answer;

        }
    }
}
