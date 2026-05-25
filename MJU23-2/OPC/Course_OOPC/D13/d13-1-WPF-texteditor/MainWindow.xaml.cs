using Microsoft.Win32;
using System.IO;
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

namespace d13WPFTextEdit
{
    public partial class MainWindow : Window
    {
        string filePath = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuNewClick(object sender, RoutedEventArgs e)
        {
            EditArea.Text = "";
        }
        private void MenuOpenClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                filePath = openFileDialog.FileName;
                StatusField.Text = $"File: {filePath}";
                EditArea.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
        private void MenuSaveClick(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(filePath, EditArea.Text);
        }
        private void MenuExitClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
