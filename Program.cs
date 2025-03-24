using propriedades;

Pessoa p1 = new Pessoa(nome:"Pedro",sobrenome:"Vieira");
Pessoa p2 = new Pessoa(nome:"João",sobrenome: "Silva");
Pessoa p3 = new Pessoa(nome:"Maria",sobrenome:"Pereira");
Pessoa p4 = new Pessoa(nome:"Ana",sobrenome: "Gomes");
Pessoa p5 = new Pessoa(nome:"Carlos",sobrenome: "Almeida");
Pessoa p6 = new Pessoa(nome:"Beatriz",sobrenome: "Santos");

Curso Ingles = new Curso();
Ingles.Nome = "Inglês Básico";
Ingles.Alunos = new List<Pessoa>();

Ingles.Alunos.Add(p1);
Ingles.Alunos.Add(p2);
Ingles.Alunos.Add(p3);
Ingles.Alunos.Add(p4);
Ingles.Alunos.Add(p5);
Ingles.Alunos.Add(p6);

Ingles.ListarAlunos();
Console.WriteLine(Ingles.QtdAluno());
