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

namespace Number_guessing_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int n;
        public MainWindow()
        {
            InitializeComponent();
        }
        

        public void button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
           
            Window1 win2 = new Window1();
            win2.Show();
            Close();
            if (checkBox.IsChecked ?? true)
            {
                n = rnd.Next(1, 10);
            }
            else if (checkBox1.IsChecked ?? true)
            {
                n = rnd.Next(1, 50);
            }
            else if (checkBox2.IsChecked ?? true)
            {
                n = rnd.Next(1, 100);
            }
           
        }

        public void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }

       public void checkBox2_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }



        private void TRY_Click(object sender, RoutedEventArgs e)
        {
            int score=0;
            int x = MainWindow.n;
            int i = Convert.ToInt32(textBox.Text);
            if (i == x)
            {
                textBlock.Text = "That IS Correct";
            }
            else if (x > i)
            {
                textBlock.Text = "Try To Geuss higher";
                score++;
            }
            else
            {
                textBlock.Text = "Try To Guess Lower";
                score++;
            }
        }
    }
}
