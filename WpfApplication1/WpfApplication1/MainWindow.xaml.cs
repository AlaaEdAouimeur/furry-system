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

namespace hhhhh
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int n = 0;
            Random rnd = new Random();
            if (checkBox.IsChecked ?? true)
            {
                n = rnd.Next(1, 10);
            }
            if (checkBox1.IsChecked ?? true)
            {
                n = rnd.Next(1, 50);
            }
            if (checkBox2.IsChecked ?? true)
            {
                n = rnd.Next(1, 100);
            }
            textBlock.Text = n.ToString();
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
