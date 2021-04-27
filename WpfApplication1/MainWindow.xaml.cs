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

namespace WpfApplication1
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

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {
            game.playerNumber = 2;
        }

        private void RadioButton2_Checked(object sender, RoutedEventArgs e)
        {
            game.playerNumber = 3;
        }

        private void RadioButton3_Checked(object sender, RoutedEventArgs e)
        {
            game.playerNumber = 4;
        }

        private void buttonClick(object sender, RoutedEventArgs e)
        {
            game gameWindow = new game();                          
            gameWindow.Show(); 
        }


    }
}
