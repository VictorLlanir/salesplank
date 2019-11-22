using Salesplank.Enums;
using Salesplank.Helpers;
using System;

namespace Salesplank.Entities
{
    public class Project
    {
        public Project(string name, string image, EProjectType projectType, string place, string date)
        {
            Name = name;
            Image = image;
            ProjectType = projectType;
            Place = place;
            Date = date;
        }
        public virtual string Image { get; private set; }
        public virtual string Name { get; private set; }
        public virtual EProjectType ProjectType { get; private set; }
        public virtual string Place { get; private set; }
        public virtual string Date { get; private set; }

        public override string ToString() => $"{Name} - {EnumHelper.GetDescription(ProjectType)}";
    }
}
