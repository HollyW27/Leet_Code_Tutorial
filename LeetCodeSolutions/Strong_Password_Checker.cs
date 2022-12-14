namespace StrongPasswordChecker;
public class Solution 
{
    public bool StrongPasswordCheckerII(string password) 
    {
        int upper = 0;
        int lower = 0;
        int digit = 0;
        int special = 0;
        if (password.Length < 8)
        {
            return false;
        }
        for(int i = 0; i < password.Length; i++)
        {
            if (i < password.Length - 1 && password[i] == password[i+1])
            {
                return false;
            }
            if (char.IsLower(password[i]))
            {
                lower++;
            }
            else if(char.IsLetter(password[i]))
            {
                upper++;
            }
            else if(char.IsNumber(password[i]))
            {
                digit++;
            }
            else
            {
                special++;
            }
        }
            if(special > 0 && upper > 0 && lower > 0 && digit > 0)
                {
                    return true;
                }
            else
            {
                return false;
            }
    }
}