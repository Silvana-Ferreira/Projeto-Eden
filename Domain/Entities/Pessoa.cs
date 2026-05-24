using Domain.Interfaces;
using Domain.ValueObjects;
 
namespace Domain.Entities
{
    public class Pessoa
    {
        public Guid Id { get; private set; }
        public string NomeCompleto => ObterNomeCompleto();
        public string PrimeiroNome { get; private set; }
        public string SegundoNome { get; private set; }
        public string UltimoNome { get; private set; }
        public string NumeroDocumento { get; private set; }
        public string TipoDocumento { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public Telefone Telefone { get; private set; }
        public Endereco Endereco { get; private set; }
        public string Email { get; private set; }
 
        private readonly List<IPapel> _papeis = new();
 
        public IReadOnlyCollection<IPapel> Papeis => _papeis;
 
        public void AdicionarPapel(IPapel papel)
        {
            _papeis.Add(papel);
        }
 
        public T? ObterPapel<T>() where T : class, IPapel
        {
            return _papeis.OfType<T>().FirstOrDefault();
        }
 
        private string ObterNomeCompleto()
        {
            return $"{PrimeiroNome} {SegundoNome} {UltimoNome}";
        }
    }
}
 