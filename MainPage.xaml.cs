namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        Game jogo = new Game();

        public MainPage()
        {
            InitializeComponent();
        }

        private void FlipDice_Clicked(object sender, EventArgs e)
        {
            Dice dado = new dado();
            DadoImage.Source = dado.Flip() + ".png";

            int sorteio = dado.LadoSorteado == "1" ? 0 : 1;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
