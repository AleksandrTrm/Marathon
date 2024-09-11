using System.Collections.Generic;

namespace Marathone.Model
{
    public class Fondation
    {
        private string _title;
        private string _sponsorInfo;
        private string _pictureSource;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Info
        {
            get { return _sponsorInfo; }
            set { _sponsorInfo = value; }
        }

        public string Source
        {
            get { return _pictureSource; }
            set { _pictureSource = value; }
        }        

        public Fondation(string title, string info, string source)
        {
            _title = title;
            _sponsorInfo = info;
            _pictureSource = source;
        }        
    }

    public static class Fondations
    {
        public static readonly List<Fondation> FondationsList = new List<Fondation>()
        {
            new Fondation("Фонд кошек", "фонд кошек основанный в 882 году", @"\Assets\cat.png"),
            new Fondation("Фонд собак", "фонд собак основанный в 1238", @"\Assets\dog.png"),
            new Fondation("Фонд единорогов", "фонд единорогов основанный в 1939 году", @"\Assets\unicorn.png"),
            new Fondation("Фонд скатов", "фонд скатов основанный в 1914 году", @"\Assets\stingray.png"),
            new Fondation("Фонд волшебников", "фонд волшебников основанный в 1989", @"\Assets\wizard.png")
        };
    }
}
