using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace d8_wpf_tasks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    /// <references>
    ///    <ref id="ref1">
    ///       <title>How to run and interact with an async Task from a WPF gui</title>
    ///       <url>
    ///          https://stackoverflow.com/questions/27089263/how-to-run-and-interact-with-an-async-task-from-a-wpf-gui
    ///       </url>
    ///    </ref>
    /// </references>
    public partial class MainWindow : Window
    {
        static AsyncQueue<int> aq = new AsyncQueue<int>();
        DispatcherTimer dispatcherTimer;
        public MainWindow()
        {
            InitializeComponent();
            // Allt här:
            // ...
            StartTimer();
            Task<A> mt = MainTaskAsync();
        }
        public class A
        {
            public enum Resultat { Bra, Dåligt, Sisådär }
            public Resultat resultat;
            public A(Resultat resultat) { this.resultat = resultat; }
        }
        public static async Task<A> MainTaskAsync()
        {
            Task<A> t1 = Task1Async();
            Task<A> t2 = Task2Async();
            // t1.Start(); DON'T! See "WPF GUI > Blocking:" at <ref id="ref1"/> (see above!)
            // t2.Start();
            A r1 = await t1;
            A r2 = await t2;
            return new A(A.Resultat.Bra);
        }
        public static async Task<A> Task2Async()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(700);
                aq.Enqueue(2);
            }
            aq.Enqueue(4);
            return new A(A.Resultat.Bra);
        }
        public static async Task<A> Task1Async()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(900);
                aq.Enqueue(1);
            }
            aq.Enqueue(3);
            return new A(A.Resultat.Bra);
        }
        public void StartTimer()
        {
            // Källa: https://learn.microsoft.com/en-us/dotnet/api/system.windows.threading.dispatchertimer?view=windowsdesktop-8.0
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(UpdateCountdown);
            dispatcherTimer.Interval = TimeSpan.FromSeconds(0.25);
            dispatcherTimer.Start();
        }
        public void cleanUp(TextBlock tblk)
        {
            int numLines = tblk.Text.Split('\n').Length;
            if (numLines > 11) tblk.Text = "";
        }
        public void UpdateCountdown(object source, EventArgs e)
        {
            cleanUp(mainout);
            cleanUp(out1);
            cleanUp(out2);

            if (aq.Count > 0)
            {
                int i;
                if (aq.TryDequeue(out i))
                {
                    mainout.Text += $"\naq.elem {i}!";
                    switch (i)
                    {
                        case 1: out1.Text += "\nmessage"; break;
                        case 2: out2.Text += "\nmessage"; break;
                        case 7: dispatcherTimer.Stop(); mainout.Text += "\nSTOP"; break;
                    }
                }
            }
            else
            {
                mainout.Text += "\n(tick)";
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
