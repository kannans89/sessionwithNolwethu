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
using System.Windows.Shapes;

namespace SimpleWpfUIApp
{
    /// <summary>
    /// Interaction logic for GreetingWindow.xaml
    /// </summary>
    public partial class GreetingWindow : Window
    {
        public GreetingWindow()
        {
            InitializeComponent();

            clickMeButton.Click += SayHello;
            clickMeButton.Click += SayGoodBye;
        }

        private void SayHello(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Saying hello to "+userNameTextBox.Text);
        }
        private void SayGoodBye(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Saying Good byte to "+userNameTextBox.Text);
        }
    }
}
