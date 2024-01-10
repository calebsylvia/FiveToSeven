namespace FiveToSeven.Services.MadLib;

public class MadLibService : IMadLibService
{
    public string MadLib(string userName, string name, int age, string noun1, string noun2, string verb1, string verb2, string adjective)
    {
        return $"Welcome {userName}! This is a story about a {age} year old boy who couldn't get a {noun1} out of his nose. One day {name} was {verb1} around the house, he was a very {adjective} kid and always had a smile on his face. On this day he had slipped and fell onto a {noun1} face first and found it lodged into his nose. His mom saw this and tried to pry it out with a {noun2}. Nothing was working, his mom was {verb2} and freaking out. They ran to the hospital and they were able to safely remove it. The End!";
    }
}
