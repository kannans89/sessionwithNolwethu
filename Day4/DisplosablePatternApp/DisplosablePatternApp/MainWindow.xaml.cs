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

namespace DisplosablePatternApp
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

        private void btn1_click(object sender, RoutedEventArgs e)
        {
            Clone c = new Clone(101);
            c = null;

            MessageBox.Show("btn1_click end");
        }

        private void btn2_click(object sender, RoutedEventArgs e)
        {

            //Clone c = new Clone(102);
            //c.Dispose();

            using (Clone c = new Clone(102)) { 
            
            }

            using (StreamReader sr = new StreamReader(@"c:\temp\add.py"))
            {
                MessageBox.Show(sr.ReadToEnd()); 
            }


           MessageBox.Show("end of btn2 click");

        }

        private void btn3_click(object sender, RoutedEventArgs e)
        {
            GC.Collect();
            MessageBox.Show("Gc.btn3_click end");
        }
    }
}