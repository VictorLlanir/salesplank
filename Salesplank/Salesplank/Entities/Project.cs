using System;

namespace Salesplank.Entities
{
    public class Project
    {
        public Project(Guid id, string logo, string name, string type, string description, string place, string date)
        {
            Id = id;
            Logo = logo;
            Name = name;
            Type = type;
            Description = description;
            Place = place;
            Date = date;
        }
        public virtual Guid Id { get; set; }
        public virtual string Logo { get; set; }
        public virtual string Name { get; set; }
        public virtual string Type { get; set; }
        public virtual string Description { get; set; }
        public virtual string Place { get; set; }
        public virtual string Date { get; set; }
    }
}
