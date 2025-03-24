namespace propriedades
{
    public class Pessoa
    {

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        public string Nome
        {
            get => _nome;
            
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}";

        private int _idade;
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser negativa");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} de idade");
        }

    }
}


