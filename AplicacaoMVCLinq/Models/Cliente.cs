namespace AplicacaoMVCLinq.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateOnly DataNasc { get; set; }
        public Cliente(int id, string nome, string email, string tefone, DateOnly datanasc)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = tefone;
            this.DataNasc = datanasc;
        }
    }

}
