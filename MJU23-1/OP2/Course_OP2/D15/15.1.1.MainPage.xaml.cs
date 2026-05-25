namespace d15mauibildbladdrare
{
    public partial class MainPage : ContentPage
    {
        string[] imageFileName =
        {
            "gora_strimba_vzhimky.jpg",
            "messier83_heic1403a.jpg",
            "mont_blanc_from_les_arcs_1950a.jpg",
            "morozhniy_ranok_nad_jaremshsheyo.jpg",
            "vintage_car_meets_world_heritage_site.jpg"
        };
        int currentImage = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void OnPrevClicked(object sender, EventArgs e)
        {
            currentImage--;
            if (currentImage == -1) currentImage = 4;
            string img = imageFileName[currentImage];
            ImageText.Text = $"Prev: {img}";
            GalleryImage.Source = img;
            SemanticScreenReader.Announce(ImageText.Text);
        }
        private void OnNextClicked(object sender, EventArgs e)
        {
            currentImage++;
            if (currentImage == 5) currentImage = 0;
            string img = imageFileName[currentImage];
            ImageText.Text = $"Next: {img}";
            GalleryImage.Source = img;
            SemanticScreenReader.Announce(ImageText.Text);
        }
    }
}
