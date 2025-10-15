using ContadorManual.GUI.Models;
namespace ContadorManual.GUI
{
    public partial class MainPage : ContentPage
    {
        private Contador contador;

        public MainPage()
        {
            InitializeComponent();
            contador = new Contador();
            ConteoLabel.Text = contador.Conteo.ToString();
        }

        private void OnContarButtonClicked(object sender, EventArgs e)
        {
            contador.Contar();
            ConteoLabel.Text = contador.Conteo.ToString();
        }

        private void OnReiniciarButtonClicked(object sender, EventArgs e)
        {
            contador.Reiniciar();
            ConteoLabel.Text = contador.Conteo.ToString();
        }
    }
}
