using System;

namespace Repository.Entities
{
    public class Projeto
    {
        public virtual Guid Id { get; set; }
        public virtual string Logo { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Tipo { get; set; }
        public virtual string Descrição { get; set; }
        public virtual string Local { get; set; }
        public virtual string Data { get; set; }
    }
}
