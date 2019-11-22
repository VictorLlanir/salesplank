using Salesplank.Enums;
using Salesplank.Helpers;

namespace Salesplank.Entities
{
    public class Action
    {
        public Action(string name, string image, EProjectType projectType, EActionType actionType)
        {
            Name = name;
            Image = image;
            ProjectType = projectType;
            ActionType = actionType;
        }
        public string Name { get; private set; }
        public string Image { get; private set; }
        public EProjectType ProjectType { get; private set; }
        public EActionType ActionType { get; private set; }

        public override string ToString() => $"{Name} - {EnumHelper.GetDescription(ActionType)} - {EnumHelper.GetDescription(ProjectType)}";
    }
}
