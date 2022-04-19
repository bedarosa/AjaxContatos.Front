using AjaxContatos.Domain.BaseEntity;

namespace AjaxContatos.Domain.Entities
{
    public class Contato : Entity
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
    }
}
