namespace Clientes.Models
{
    public class AddClienteRequest
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }

        public string Endereco { get; set; }

    }
}
