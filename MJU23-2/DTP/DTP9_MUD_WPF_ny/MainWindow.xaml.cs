using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DTP9_MUD_WPF
{
    public partial class MainWindow : Window
    {
        string imgDir = "..\\..\\..\\images\\";
        public MainWindow()
        {
            InitializeComponent();
            // Gör all initiering nedanför den här texten!
            // Title.Text = "SIMSALABIM!";
            Title.Text = Labyrinth.CurrentTitle();
            // StoryField.Text = "Abrakadabra\nhokus pokus\nfiliokus";
            StoryField.Text = Labyrinth.CurrentText() + "\n" +
                Labyrinth.WarningText();
            // NYI: Labyrinth.CurrentImage();
            Uri img = new Uri(imgDir+ Labyrinth.CurrentImage(), UriKind.RelativeOrAbsolute);
            MainImage.Source = BitmapFrame.Create(img);
        }
        private void ApplicationKeyPress(object sender, KeyEventArgs e)
        {
            string output = "Key pressed: ";
            output += e.Key.ToString();
            KeyPressDisplay.Text = output;
            if (e.Key == Key.Escape)
            {
                System.Windows.Application.Current.Shutdown();
            }
            else if (e.Key == Key.A)
            {
                Title.Text = "AAAAAAAAAH!";
                StoryField.Text = "Namen aaaaah!\nÅååååh!\nÄäääää!";
                Uri img = new Uri(imgDir + "illusion2.png", UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            else if (e.Key == Key.I)
            {
                Title.Text = "IIIIIIIIIH!";
                StoryField.Text = "Jasäjabah iiiiiiiih!";
                Uri img = new Uri(imgDir + "winterbath.png", UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            else if (e.Key == Key.H)
            {
                Title.Text = Labyrinth.HelpTitle();
                StoryField.Text = Labyrinth.HelpText();
                Uri img = new Uri(imgDir + Labyrinth.HelpImage(), UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            else if (e.Key == Key.Q)
            {
                Title.Text = Labyrinth.CurrentTitle();
                StoryField.Text = Labyrinth.CurrentText() + "\n" +
                    Labyrinth.WarningText();
                Uri img = new Uri(imgDir + Labyrinth.CurrentImage(), UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            else if (e.Key == Key.Up)
            {
                Labyrinth.DoCommand("w");
                Title.Text = Labyrinth.CurrentTitle();
                StoryField.Text = Labyrinth.CurrentText() + "\n" +
                    Labyrinth.WarningText();
                Uri img = new Uri(imgDir + Labyrinth.CurrentImage(), UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            else if (e.Key == Key.Left)
            {
                Labyrinth.DoCommand("a");
                Title.Text = Labyrinth.CurrentTitle();
                StoryField.Text = Labyrinth.CurrentText() + "\n" +
                    Labyrinth.WarningText();
                Uri img = new Uri(imgDir + Labyrinth.CurrentImage(), UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            else if (e.Key == Key.Right)
            {
                Labyrinth.DoCommand("d");
                Title.Text = Labyrinth.CurrentTitle();
                StoryField.Text = Labyrinth.CurrentText() + "\n" +
                    Labyrinth.WarningText();
                Uri img = new Uri(imgDir + Labyrinth.CurrentImage(), UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
            else if (e.Key == Key.Down)
            {
                Labyrinth.DoCommand("s");
                Title.Text = Labyrinth.CurrentTitle();
                StoryField.Text = Labyrinth.CurrentText() + "\n" +
                    Labyrinth.WarningText();
                Uri img = new Uri(imgDir + Labyrinth.CurrentImage(), UriKind.RelativeOrAbsolute);
                MainImage.Source = BitmapFrame.Create(img);
            }
        }
    }
}
