using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DTP9_MUD_console
{
    public class Room
    {
        public static int NoDoor = -997;
        int self;
        string title;
        string text;
        // BitmapFrame image;
        string image;
        int north, east, south, west;
        public Room(int self, string name, string text, string image, int N, int E, int S, int W)
        {
            this.self = self; this.title = name; this.text = text;
            // this.image = BitmapFrame.Create(new Uri(imgDir + image, UriKind.RelativeOrAbsolute));
            this.image = image;
            north = N; east = E; south = S; west = W;
        }
        public string Title { get { return title; } }
        public string Text { get { return text; } }
        public int North { get { return north; } }
        public int East { get { return east; } }
        public int South { get { return south; } }
        public int West { get { return west; } }
        public string Directions
        {
            get
            {
                string dir = "Det går dörrar till:\n";
                if (north != NoDoor)
                {
                    dir += "  w - norr";
                    if (north < 0) dir += " (stängd)"; dir += "\n";
                }
                if (east != NoDoor)
                {
                    dir += "  d - öster";
                    if (east < 0) dir += " (stängd)"; dir += "\n";
                }
                if (south != NoDoor)
                {
                    dir += "  s - söder";
                    if (south < 0) dir += " (stängd)"; dir += "\n";
                }
                if (west != NoDoor)
                {
                    dir += "  a - väster";
                    if (west < 0) dir += " (stängd)"; dir += "\n";
                }
                return dir;
            }
        }
        //public BitmapFrame Image
        //{
        //    get { return image; }
        //}
        public string Image { get { return image; } }
        internal void UnLock()
        {
            if (north != NoDoor && north < 0) north = -north;
            if (south != NoDoor && south < 0) south = -south;
            if (east != NoDoor && east < 0) east = -east;
            if (west != NoDoor && west < 0) west = -west;
        }
    }
    public class Labyrinth
    {
        static string imgDir = "..\\..\\..\\images\\";
        static string warning = "";
        static Room help = new Room(-1, "Help",
               "Följande kommandon finns:\n" +
               "  w - gå genom dörren norrut\n" +
               "  s - gå genom dörren söderut\n" +
               "  d - gå genom dörren österut\n" +
               "  a - gå genom dörren västerut\n" +
               "  l - leta\n" +
               "  o - öppna låsta dörrar\n" +
               "  h - hjälp\n" +
               "  z - avsluta\n",
               "key-found.png",
               Room.NoDoor, Room.NoDoor, Room.NoDoor, Room.NoDoor);
        static List<Room> labyrinth = new List<Room>() {
            new Room(0, "Start",
                "Du står i ett rum med rött\n" +
                "tegel. Väggarna fladdrar i\n" +
                "facklornas sken. Du ser en\n" +
                "hög med tyg nere till vänster. ",
                "z-ingang-stangd-m-brate.png",
                N:-3, E:Room.NoDoor, S:Room.NoDoor, W:Room.NoDoor),
            new Room(1, "Lagerrum väst",
                "Du står i ett rum utan vägar\n" +
                "framåt. Du ser en hög med\n" +
                "skräp nere till vänster.",
                "z-lagerrum-vast.png",
                N:Room.NoDoor, E:2, S:Room.NoDoor, W:Room.NoDoor),
            new Room(2, "Vaktrum väst",
                "Du står i ett övergivet vaktrum.",
                "z-vaktrum-vast.png",
                N:Room.NoDoor, E: 3, S:Room.NoDoor, W:1),
            new Room(3, "Korsvägen",
                "Du står i korsväg. Det går\n" +
                "gångar i alla riktningar.",
                "z-korsvag-stangt-v-e.png",
                N:6, E:4, S:0, W:2),
            new Room(4, "Vaktrum öst",
                "Du står i ett övergivet vaktrum.",
                "z-vaktrum-ost-m-kista.png",
                N:Room.NoDoor, E:5, S:Room.NoDoor, W:3),
            new Room(5, "Lagerrum öst",
                "Du står i ett rum utan vägar\n" +
                "framåt. Du ser en hög med\n" +
                "skräp nere till vänster.",
                "z-lagerrum-ost.png",
                N:7, E:Room.NoDoor, S:Room.NoDoor, W:4)
        };
        static int current = 0;
        public static string HelpTitle() { return help.Title; }
        public static string HelpText() { return help.Text; }
        public static void DoCommand(string command)
        {
            // FIXME: try-catch? för om ett rum inte finns!
            if (command == "w")
            {
                int next = labyrinth[current].North;
                // TBD: bryt ut en static-metod
                warning = "";
                if (next == Room.NoDoor) warning = "du gick in i väggen!\n";
                else if (next < 0) warning = "du gick in i en låst dörr!\n";
                else current = next;
            }
            else if (command == "s")
            {
                int next = labyrinth[current].South;
                warning = "";
                if (next == Room.NoDoor) warning = "du gick in i väggen!\n";
                else if (next < 0) warning = "du gick in i en låst dörr!\n";
                else current = next;
            }
            else if (command == "d")
            {
                int next = labyrinth[current].East;
                warning = "";
                if (next == Room.NoDoor) warning = "du gick in i väggen!\n";
                else if (next < 0) warning = "du gick in i en låst dörr!\n";
                else current = next;
            }
            else if (command == "a")
            {
                int next = labyrinth[current].West;
                warning = "";
                if (next == Room.NoDoor) warning = "du gick in i väggen!\n";
                else if (next < 0) warning = "du gick in i en låst dörr!\n";
                else current = next;
            }
            else if (command == "l")
            {
                warning = "du hittade ingenting\n";
            }
            else if (command == "o")
            {
                labyrinth[current].UnLock();
            }
            else
            {
                warning = "okänt kommando\n";
            }
        }
        internal static string CurrentTitle()
        {
            return labyrinth[current].Title;
        }
        internal static string CurrentText()
        {
            return labyrinth[current].Text;
        }
        internal static string WarningText()
        {
            return warning;
        }
        internal static string Directions()
        {
            return labyrinth[current].Directions;
        }
        internal static ImageSource GetImage()
        {
            // this.image = BitmapFrame.Create(new Uri(imgDir + image, UriKind.RelativeOrAbsolute));
            BitmapFrame img = BitmapFrame.Create(new Uri(imgDir + labyrinth[current].Image, UriKind.RelativeOrAbsolute));
            return img;
        }
    }
}
