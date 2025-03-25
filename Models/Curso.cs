namespace propriedades
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public bool AddALuno(Pessoa aluno)
        {
            Alunos.Add(aluno);
            return true;
        }

        public int QtdAluno()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RmvAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {

            for (int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "N°" + count + " - " + Alunos[count].NomeCompleto;
                string texto = $"N°{count} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }

            /*foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }*/
        }
    }
}


