using System.Collections.Generic;

namespace Marathone.Model
{
    public class Sprinter
    {
        private string _name;
        private int _number;
        private string _country;

        public Sprinter(string name, int number, string country)
        {
            _name = name;
            _number = number;
            _country = country;
        }

        public string SprintMember
        {
            get { return $"{_name} - {_number} ({_country})"; }
        }

    }

    public static class Sprinters
    {
        public static readonly List<Sprinter> SprintersList = new List<Sprinter>()
        {
            new Sprinter("Олег Прудов", 204, "Russia"),
            new Sprinter("Wayne Rooney", 142, "England"),
            new Sprinter("Hadoku San", 231, "Japan"),
            new Sprinter("Jake Brown", 123, "USA"),
            new Sprinter("Pier Laval", 253, "France")
        };
    }
}
