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
        private void OnClearClicked(object sender, EventArgs e)
        {
            TextEntry.Text = "";
        }
        private void OnDeleteClicked(object sender, EventArgs e)
        {
            TextEntry.Text = TextEntry.Text[0..(TextEntry.Text.Length-1)];
        }
        private void OnNumClicked(object sender, EventArgs e) {
            if(sender is Button but)
            {
                TextEntry.Text += but.Text;
            }
            else
            {
                TextEntry.Text = "(shouldn't happen)";
            }
            
        }
        private void OnEntryCompleted(object sender, EventArgs e)
        {
            double result = shuntingyard.ShuntingYard.Execute(TextEntry.Text);
            ResultText.Text = $"result = {result}";
        }
    }
}
