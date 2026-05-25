namespace mju23_opc_MAUI_hi_lo
{
    public partial class MainPage : ContentPage
    {
        Random random = new Random();
        int randint;
        public MainPage()
        {
            InitializeComponent();
            randint = random.Next(0, 101);
        }

        private void OnGuessClicked(object sender, EventArgs e)
        {
            string numStr = Guess.Text;
            try
            {
                int iguess = Int32.Parse(numStr);
                if(iguess < 0 || 100 < iguess)
                {
                    MessageText.Text = "Talet skall vara mellan 0 och 100!";
                }
                else if (iguess == randint)
                {
                    MessageText.Text = $"Rätt!! Talet var {iguess}! Gissa ett nytt tal!";
                    randint = random.Next(0, 101);
                }
                else if (iguess < randint)
                {
                    MessageText.Text = "Talet är större! Gissa igen!";
                }
                else 
                {
                    MessageText.Text = "Talet är mindre! Gissa igen!";
                }
            }
            catch (Exception)
            {
                MessageText.Text = "Inte ett nummer: " + numStr;
            }
            SemanticScreenReader.Announce(MessageText.Text);
            Guess.Text = "";
            SemanticScreenReader.Announce(Guess.Text);
        }
    }
}