using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace D8_porting
{
    public class Scene
    {
        string title;
        string text;
        int next, previous;
        public Scene(string name, string text, int previous, int next)
        {
            this.title = name; this.text = text; this.previous = previous; this.next = next;
        }
        public string Title { get { return title; } }
        public string Text { get { return text; } }
        public int Next { get { return next; } }
        public int Previous { get { return previous; } }
    }
    public class Scenery
    {
        static List<Scene> scenes = new List<Scene>() {
            new Scene("Start",
                "Starta spelet genom att skriva 'n'\n" +
                "Kommandon (i spelet):\n" +
                "  f - föregående scen\n" +
                "  n - nästa scen\n" +
                "  s - skriv om nuvarande scen\n" +
                "  x - gå ur sceneriet\n",
                0, 1),
            new Scene("Badstranden",
                "Du står på en vacker sandstrand.\n" +
                "Solen lyser. Vinden blåser i håret.\n" +
                "Palmerna vajar i vinden. Du ser\n" +
                "inte en människa så långt ögat når.",
                0, 2),
            new Scene("Vattnet",
                "Du simmar i vatten. Det är ljummet och\n" +
                "alldeles perfekt temperatur. Färgen\n" +
                "är blågrön och vattnet är klart.\n" +
                "Du ser några små fiskar simma omkring.",
                1, 3),
            new Scene("Havsbotten",
                "Du känner att du kan andas i vattnet.\n" +
                "Du känner dig som en fisk som lätt\n" +
                "simma i vilken riktning du vill. Nere\n" +
                "På havsbottnen ser du något som ser ut\n"+
                "som en rund hydda av sten.",
                2, 0)
        };
        static int current = 0;
        public static string HelpTitle() { return scenes[0].Title; }
        public static string HelpText() { return scenes[0].Text; }
        public static void DoCommand(string command)
        {
            if(command == "n") { current = scenes[current].Next; }
            else if(command == "p") { current = scenes[current].Previous; }
            else if (command == "s") { }
            else { }
        }

        internal static string CurrentTitle(string command)
        {
            return scenes[current].Title;
        }

        internal static string CurrentText(string command)
        {
            return scenes[current].Text;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string title;
            string text;
            Console.WriteLine("Välkommen till sceneriet!");
            title = Scenery.HelpTitle();
            text = Scenery.HelpText();


            Console.WriteLine("--------------");
            Console.WriteLine(title);
            Console.WriteLine("--------------");
            Console.WriteLine(text);
            Console.WriteLine("--------------");
            Console.WriteLine("Skriv 'h' för hjälp, 'x' för att sluta!");

            do
            {
                Console.Write("> ");
                string command = Console.ReadLine();
                if(command == "x")
                {
                    Console.WriteLine("Hej då!");
                    break;
                }
                else if(command == "h")
                {
                    title = Scenery.HelpTitle();
                    text = Scenery.HelpText();
                }
                else
                {
                    Scenery.DoCommand(command);
                    title = Scenery.CurrentTitle(command);
                    text = Scenery.CurrentText(command);
                }
                Console.WriteLine("--------------");
                Console.WriteLine(title);
                Console.WriteLine("--------------");
                Console.WriteLine(text);
                Console.WriteLine("--------------");
                Console.WriteLine("Skriv 'h' för hjälp, 'x' för att sluta!");
            } while (true);
        }
    }
}