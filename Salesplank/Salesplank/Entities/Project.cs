using Salesplank.Enums;
using Salesplank.Helpers;

namespace Salesplank.Entities
{
    public class Project
    {
        public Project(string name, string image, string report, string description, EProjectType projectType, string place, string date, string link)
        {
            Name = name;
            Image = image;
            Report = report;
            Description = description;
            ProjectType = projectType;
            Place = place;
            Date = date;
            Link = link;
        }
        public virtual string Name { get; private set; }
        public virtual string Image { get; private set; }
        public virtual string Report { get; private set; }
        public virtual string Description { get; private set; }
        public virtual EProjectType ProjectType { get; private set; }
        public virtual string Place { get; private set; }
        public virtual string Date { get; private set; }
        public virtual string Link { get; private set; }

        public override string ToString() => $"{EnumHelper.GetDescription(ProjectType)} - {Name}";
    }
}
