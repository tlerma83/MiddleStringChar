namespace MiddleCharInString
{
    public class Kata
    {
        // solution using terniery operators
        public static string GetMiddle(string s) 
        {
            return string.IsNullOrEmpty(s) ? s : s.Substring((s.Length -1) / 2, 2 - (s.Length % 2));
        }

        // solution using if / else statement
        public static string GetMiddle2(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return s;
            }else
            {
                return s.Substring((s.Length -1) / 2, 2 - (s.Length % 2)); 
            }
            
        }
    }
}