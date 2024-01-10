namespace FiveToSeven.Services.ReverseItN;

public class ReverseItNService : IReverseItNService
{
    public string ReverseItN(string input)
    {
        int reverseIntOutput = 0;
            bool isTrue = int.TryParse(input, out int num);
            if(isTrue)
            {
                while (num != 0)
                {
                    reverseIntOutput = reverseIntOutput * 10 + (num % 10);
                    num = num / 10;
                }
            }
            else
            {
                return "Please enter in an integer!";
            }
            return $"Your reversed int input is: {reverseIntOutput}!";
    }
}
