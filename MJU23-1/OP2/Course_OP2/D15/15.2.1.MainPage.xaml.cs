using shuntingyard;

namespace d15mauiraknedosa
{
    public partial class MainPage : ContentPage
    {
        int currentImage = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void OnPrevClicked(object sender, EventArgs e)
        {
            currentImage--;
            if (currentImage == -1) currentImage = 4;
        }
        private void OnNextClicked(object sender, EventArgs e)
        {
            currentImage++;
            if (currentImage == 5) currentImage = 0;
        }
        private void OnEntryCompleted(object sender, EventArgs e)
        {
            double result = shuntingyard.ShuntingYard.Execute(TextEntry.Text);
            ResultText.Text = $"result = {result}";
        }
    }
}
