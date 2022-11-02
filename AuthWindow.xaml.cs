using SheiApp.Models;
using SheiApp.Windows;
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

namespace SheiApp
{
    /// <summary>
    /// Interaction logic for AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }
        private void voitiBtn_Click(object sender, RoutedEventArgs e)
        {
            if (loginTB.Text != "" && parolTB.Text != "")
            {
                Polzovatel p = ShveiEntities.GetContext.Polzovatels.Where(q => q.Login == loginTB.Text).FirstOrDefault();
                if (p == null)
                {
                    MessageBox.Show("Пользователя с таким логином нет");
                    return;
                }
                if (p.Parol != parolTB.Text)
                {
                    MessageBox.Show("Неправильный пароль");
                    return;
                }
                Global.Polzovatel = p;
                new MainWindow().Show();
                this.Close();
            }
        }

        private void regBtn_Click(object sender, RoutedEventArgs e)
        {
            new RegWindow().Show();
            this.Close();
        }
    }
}
