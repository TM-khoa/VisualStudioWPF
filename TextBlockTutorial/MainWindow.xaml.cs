using System.Diagnostics;
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

namespace TextBlockTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock? txbl = sender as TextBlock;
            txbl!.Text = "Truong Minh Khoa";
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock? txbl = sender as TextBlock;
            txbl!.Text = "SpiritBoi";
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            try 
            {
                var psi = new ProcessStartInfo
                {
                    FileName = e.Uri.AbsoluteUri,
                    UseShellExecute = true
                };
                Process.Start(psi);
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            e.Handled = true;
        }
    }
}