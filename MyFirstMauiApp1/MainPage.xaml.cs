namespace MyFirstMauiApp1
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Entrar_Clicked(object sender, EventArgs e)
        {
            string nome = InputUsuario.Text;
            string senha = InputSenha.Text;

            if (nome == "Arthur" && senha == "senac123")
            {
                await DisplayAlert("Sucesso", "Sabemos quem é você", "Fechar");
            }else
            {
                await DisplayAlert("Usuario Negado", "Fechar", "Salvar");
            }

        }

    }

}
