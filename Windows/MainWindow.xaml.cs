using SheiApp.Models;
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

namespace SheiApp.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame Frame { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Frame = mainFrame;
            zak.Visibility = Global.Polzovatel.Role == "Менеджер" || Global.Polzovatel.Role == "Заказчик" ? Visibility.Visible : Visibility.Collapsed;
            izd.Visibility = Global.Polzovatel.Role == "Менеджер" || Global.Polzovatel.Role == "Директор" ? Visibility.Visible : Visibility.Collapsed;
            tkani.Visibility = Global.Polzovatel.Role == "Кладовщик" ? Visibility.Visible : Visibility.Collapsed;
            fur.Visibility = Global.Polzovatel.Role == "Кладовщик" ? Visibility.Visible : Visibility.Collapsed;
            post.Visibility = Global.Polzovatel.Role == "Кладовщик" ? Visibility.Visible : Visibility.Collapsed;
            otchety.Visibility = Global.Polzovatel.Role == "Директор" ? Visibility.Visible : Visibility.Collapsed;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Global.Polzovatel = null;
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Zakazy());
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new IzdeliyaWindow());
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new TkaniWindow());
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new FurnituraWindow());
        }

        private void post_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new PostupleniyaWindow());
        }

        private void otchety_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new OtchetyWindow());
        }
    }
}
