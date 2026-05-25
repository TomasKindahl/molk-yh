using Microsoft.Win32;
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
using System.IO;

namespace opc1_d11_WPF_texteditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBar.Text = "Untitled";
        }
        private void MenuNew(object sender, RoutedEventArgs e)
        {
            TextEdit.Text = "";
            MessageBar.Text = "Untitled";
        }
        private void MenuOpen(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                TextEdit.Text = File.ReadAllText(openFileDialog.FileName);
                MessageBar.Text = openFileDialog.FileName;
            }
        }
        private void MenuSave(object sender, RoutedEventArgs e)
        {
            if (MessageBar.Text == "Untitled")
            {
                // Per https://wpf-tutorial.com/dialogs/the-savefiledialog/
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == true)
                    File.WriteAllText(saveFileDialog.FileName, MessageBar.Text);
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(MessageBar.Text))
                {
                    sw.Write(TextEdit.Text);
                }
            }
        }
        private void MenuQuit(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
