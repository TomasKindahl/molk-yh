using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Input;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using System;
using System.IO;

namespace dtp8_MUD_ava
{
    class Room
    {
        // Constants:
        public const int North = 0;
        public const int East = 1;
        public const int South = 2;
        public const int West = 3;
        public const int NoDoor = -1;

        // Object attributes:
        public int number;
        public string roomname = "";
        public string story = "";
        public string imageFile = "";
        public int[] adjacent = new int[4]; // adjacent[Room.North] etc.
        public Room(int num, string name)
        {
            number = num; roomname = name;
        }
        public void SetStory(string theStory)
        {
            story = theStory;
        }
        public void SetImage(string theImage)
        {
            imageFile = theImage;
        }
        public void SetDirections(int N, int E, int S, int W)
        {
            adjacent[North] = N; adjacent[East] = E; adjacent[South] = S; adjacent[West] = W;
        }
        public int GetNorth() => adjacent[North];
        public int GetEast() => adjacent[East];
        public int GetSouth() => adjacent[South];
        public int GetWest() => adjacent[West];
    }
    public partial class MainWindow : Window
    {
        Room[] labyrinth = new Room[100];
        int currentRoom;

        public MainWindow()
        {
            InitializeComponent();

            // Init Rooms here:
            Room R;
            R = new Room(0, "Startrummet");
            R.SetStory("Du står i ett rum med rött tegel. Väggarna fladdrar i facklornas sken. Du ser en hög med tyg nere till vänster. ");
            R.SetImage("ingang-stangd.png");
            R.SetDirections(N: 1, E: Room.NoDoor, S: Room.NoDoor, W: Room.NoDoor);
            labyrinth[0] = R;

            R = new Room(1, "Korsvägen");
            R.SetStory("Du står i korsväg. Det går gångar i alla riktningar. ");
            R.SetImage("vagskal.png");
            R.SetDirections(N: 2, E: 3, S: 0, W: 4);
            labyrinth[1] = R;

            currentRoom = 0;
            DisplayCurrentRoom();
        }
        private void ApplicationKeyPress(object sender, KeyEventArgs e)
        {
            Console.WriteLine(e.Key.ToString());
            string output = "Key pressed: ";
            output += e.Key.ToString();
            // output += ", ";
            // output += AppDomain.CurrentDomain.BaseDirectory;
            KeyPressDisplay.Text = output;
            if(e.Key == Key.Escape) {
                 base.Close(0);
            }
            else if(e.Key == Key.Up)
            {
                currentRoom = labyrinth[currentRoom].GetNorth();
                DisplayCurrentRoom();
            }
        }
        private void DisplayCurrentRoom()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            Room R = labyrinth[currentRoom];
            string bitmapFileName = $"{baseDir}/{R.imageFile}";
            if (File.Exists(bitmapFileName))
            {
                RoomImage.Source = new Bitmap(bitmapFileName);
            }
            string text = $"Du befinner dig i {R.roomname}. ";
            text += R.story+" ";
            if (R.GetNorth() != Room.NoDoor) text += "Det finns en gång norrut. ";
            if (R.GetEast() != Room.NoDoor) text += "Det finns en gång österut. ";
            if (R.GetSouth() != Room.NoDoor) text += "Det finns en gång söderut. ";
            if (R.GetWest() != Room.NoDoor) text += "Det finns en gång västerut. ";
            RoomText.Text = text;

            /* Andra texter som man kan sätta:
             * KeyAlt1.Text = "upp      gå norrut"; 
             * KeyAlt2.Text = "vänster  gå västerut"; 
             * ... etc. ...
             */
        }
    }
}