namespace FiveToSeven.Services.MadLib;

    public interface IMadLibService
    {
        string MadLib(string userName, string name, int age, string noun1, string noun2, string verb1, string verb2, string adjective);
    }
