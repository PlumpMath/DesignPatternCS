namespace DesignPatterns.Creational.Prototype.Sample
{
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }

    public class Developper : IEmployee
    {

        public int WordsPerMinute { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string PrefferedLanguage { get; set; }

        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2} - {3}wpm", Name, Role, PrefferedLanguage, WordsPerMinute);
        }
    }

    public class Typist : IEmployee
    {
        public int WordsPerMinute { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}wpm", Name, Role, WordsPerMinute);
        }
    }
}
