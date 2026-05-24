using Domain.Interfaces;
 
namespace Domain.Entities
{
    public class Aluno : Pessoa
    {
        public string Matricula { get; private set; }
        //public override bool PodeAcessarNotas() => return true;
    }
}
 