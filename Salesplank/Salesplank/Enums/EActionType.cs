using System.ComponentModel;

namespace Salesplank.Enums
{
    public enum EActionType
    {
        [Description("Conteúdo")]
        Content = 1,
        [Description("Relacionamento")]
        Relationship = 2,
        [Description("Branding")]
        Branding = 3
    }
}
