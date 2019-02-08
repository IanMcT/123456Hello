/*Ian McTavish
 * Feb 6, 2019
 * Hello world my first and fav program
 */
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

namespace _123456HelloWorld
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

        private void btnGreeting_Click(object sender, RoutedEventArgs e)
        {
            //what I type here will run when button pressed
            string name = txtName.Text;
            message.Content = "Hello, " + name;
        }
    }
}

