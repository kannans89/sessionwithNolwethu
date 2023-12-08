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

namespace ThreadWpfApp
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

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintingService service = new PrintingService();
            service.Print();
            MessageBox.Show("btnPrint_Click end (walking)");
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello clicked");
        }

        private void btnPritnThread_Click(object sender, RoutedEventArgs e)
        {

            Thread t1 = new Thread(() =>
            {
                PrintingService service = new PrintingService();
                service.Print();

            });

            t1.Start();
            MessageBox.Show("btnPritnThread_Click end(walking)");
        }

        private  void btnPrintAsync2_Click(object sender, RoutedEventArgs e)
        {
            PrintingService service = new PrintingService();
            service.PrintAsync1();
            MessageBox.Show("btnPrintAsync2_Click end(walking)");
        }

        private async void PrintAsync2WithResult_Click(object sender, RoutedEventArgs e)
        {
            PrintingService service = new PrintingService();
            int result = await service.PrintAsyncWithResult();
            MessageBox.Show("PrintAsync2WithResult_Click end(walking) "+result);

        }
    }
}