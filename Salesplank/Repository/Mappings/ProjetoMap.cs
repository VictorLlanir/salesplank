using FluentNHibernate.Mapping;
using Repository.Entities;

namespace Repository.Mappings
{
    public class ProjetoMap : ClassMap<Projeto>
    {
        public ProjetoMap()
        {
            Id(p => p.Id);
            Map(p => p.Logo);
            Map(p => p.Nome);
            Map(p => p.Tipo);
            Map(p => p.Descrição);
            Map(p => p.Local);
            Map(p => p.Data);
            Table("Projetos");
        }
    }
}
