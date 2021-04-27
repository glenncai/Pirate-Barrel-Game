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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for game.xaml
    /// </summary>
    public partial class game : Window
    {
        public int rndNumber;
        public int index = 0;
        public int countTime = 10;
        public int flag = 1;
        public static int playerNumber = 0;

        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        public game()
        {
            InitializeComponent();
            printMessage();
            Random rand = new Random();
            rndNumber = rand.Next(1, 13);
         
            countTime = 10;
       
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Start();

        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            // From 9s to 0s, total 10 seconds
            countTime--;
           
            if (countTime == 0)
            {
                index = rndNumber;
                Loser();
                timeShow.Content = $"0s";
                dispatcherTimer.Stop();;
            }
            else
            {
                timeShow.Content = countTime + "s";
            }
        }
     

        public void printMessage()
        {

            if (flag % (playerNumber + 1) == 1)
            {
                showPlayer.Content = "Choose:Player1";
            }
            if (flag % (playerNumber + 1) == 2)
            {
                showPlayer.Content = "Choose:Player2";
            }
            if (flag % (playerNumber + 1) == 3)
            {
                showPlayer.Content = "Choose:Player3";
            }
            if (flag % (playerNumber + 1) == 4)
            {
                showPlayer.Content = "Choose:Player4";
            }
        }
        Random rand = new Random();
        Color[] colors = new Color[] { Colors.Red, Colors.Aquamarine, Colors.DimGray, Colors.Firebrick };

        public void Loser()
        {
            countTime = 10;
            if (flag >= playerNumber)
            {
                flag = 0;

            }
            if (index == rndNumber)
            {
                // draw the Canvas
                Ellipse circle = new Ellipse();
                circle.Width = 50;
                circle.Height = 50;
                circle.StrokeThickness = 2;
                circle.Stroke = Brushes.Black;
               
                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = colors[rand.Next(0, 4)];
                circle.Fill = mySolidColorBrush;
                canvas2D.Children.Add(circle);
                Canvas.SetLeft(circle, rand.Next(100));
                Canvas.SetTop(circle, rand.Next(10));
                dispatcherTimer.Stop(); 

                if (flag % (playerNumber + 1) == 1)
                {
                    loserShow.Content = "lose:Player1";
                }
                if (flag % (playerNumber + 1) == 2)
                {
                    loserShow.Content = "lose:Player2";
                }
                if (flag % (playerNumber + 1) == 3)
                {
                    loserShow.Content = "lose:Player3";
                }
                if (flag % (playerNumber + 1) == 4)
                {
                    loserShow.Content = "lose:Player4";
                }
            }
        }
        private void Slot1_click(object sender, RoutedEventArgs e)
        {
            index++;
            Loser();
            flag++;
            printMessage();
            Slot1.Visibility = Visibility.Hidden;
        }

        private void Slot2_click(object sender, RoutedEventArgs e)
        {
            index++;
            Loser();
            flag++;
            printMessage();
            Slot2.Visibility = Visibility.Hidden;
        }

        private void Slot3_click(object sender, RoutedEventArgs e)
        {
            index++;
            Loser();
            flag++;
            printMessage();
            Slot3.Visibility = Visibility.Hidden;

        }

        private void Slot4_click(object sender, RoutedEventArgs e)
        {
            index++;
            Loser();
            flag++;
            printMessage();
            Slot4.Visibility = Visibility.Hidden;
        }

        private void Slot5_click(object sender, RoutedEventArgs e)
        {
            index++;
            Loser();
            flag++;
            printMessage();
            Slot5.Visibility = Visibility.Hidden;
        }

        private void Slot6_click(object sender, RoutedEventArgs e)
        {
            index++;
            Loser();
            flag++;
            printMessage();
            Slot6.Visibility = Visibility.Hidden;
        }

        private void Slot7_click(object sender, RoutedEventArgs e)
        {
            index++;
            Loser();
            flag++;
            printMessage();
            Slot7.Visibility = Visibility.Hidden;
        }

        private void Slot8_click(object sender, RoutedEventArgs e)
        {
            index++;
            Loser();
            flag++;
            printMessage();
            Slot8.Visibility = Visibility.Hidden;
        }

        private void Slot9_click(object sender, RoutedEventArgs e)
        {
            index++;
            Loser();
            flag++;
            printMessage();
            Slot9.Visibility = Visibility.Hidden;
        }

        private void Slot10_click(object sender, RoutedEventArgs e)
        {
            index++;
            Loser();
            flag++;
            printMessage();
            Slot10.Visibility = Visibility.Hidden;
        }

        private void Slot11_click(object sender, RoutedEventArgs e)
        {
            index++;
            Loser();
            flag++;
            printMessage();
            Slot11.Visibility = Visibility.Hidden;
        }

        private void Slot12_click(object sender, RoutedEventArgs e)
        {
            index++;
            Loser();
            flag++;
            printMessage();
            Slot12.Visibility = Visibility.Hidden;
        }
    }
}
