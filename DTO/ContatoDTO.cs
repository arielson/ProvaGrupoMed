using System;

namespace DTO
{
    public class ContatoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Domain.Enumerators.Sexo Sexo { get; set; }
        public int Idade 
        { 
            get 
            {
                return DateTime.Now.Year - DataNascimento.Year;
            } 
        }
    }
}
