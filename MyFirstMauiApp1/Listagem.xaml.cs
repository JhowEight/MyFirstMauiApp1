namespace MyFirstMauiApp1;

public partial class Listagem : ContentPage
{

	List<Pessoa> pessoas = new List<Pessoa>();

	public Listagem()
	{
		InitializeComponent();

		Pessoa p1 = new Pessoa();
		p1.nome = "Arthur";
		p1.idade = 19;

		Pessoa p2 = new Pessoa();
		p2.nome = "Zureta";
		p2.idade = 420;

		Pessoa p3 = new Pessoa();
		p3.nome = "Zuzu";
		p3.idade = 16;

		pessoas.Add(p1);
		pessoas.Add(p2);
		pessoas.Add(p3);

		Lista.ItemsSource = pessoas;

	}
}