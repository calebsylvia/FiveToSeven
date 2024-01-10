namespace FiveToSeven.Services.ReverseItAN;

public class ReverseItANService : IReverseItANService
{
    public string ReverseItAN(string input)
    {
        string reverseString = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverseString += input[i];
            }
            return $"Your reversed string input {reverseString}.";
    }
}
