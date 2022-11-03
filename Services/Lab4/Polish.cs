namespace Laboratorium_2_20_10_2022.Services.Lab4
{
    public class Polish : Language, ILanguage
    {
        public string Name { get; set; }
        public Polish(string name)
        {
            Name = name;
        }
        public string GetLanguageName()
        {
            return Name;
        }

        public override string getLang()
        {
            return "Polski";
        }
    }
}