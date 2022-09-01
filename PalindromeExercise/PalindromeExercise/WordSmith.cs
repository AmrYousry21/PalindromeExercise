namespace PalindromeExercise
{
    public class WordSmith 
    {
        public bool result = false;
        public bool IsAPalindrome(string word) 
        {
            if (word.ToLower() == "palindrome") 
            {
                result = true;
            }
            else 
            {
                result = false;
            }
            return result; 
        }
    }
}
