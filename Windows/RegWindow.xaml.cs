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
    /// Interaction logic for RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, RoutedEventArgs e)
        {
            if (loginTB.Text != "" && parolTB.Password != "" && parol2TB.Password != "")
            {
                Polzovatel p = ShveiEntities.GetContext.Polzovatels.Where(q => q.Login == loginTB.Text).FirstOrDefault();
                if(parolTB.Password != parol2TB.Password)
                {
                    MessageBox.Show("Пароли не совпадают");
                    return;
                }
                if(p != null)
                {
                    MessageBox.Show("Пользователь с таким логином существует");
                    return;
                }
                p = new Polzovatel();
                p.Login = loginTB.Text;
                p.Parol = parolTB.Password;
                p.Role = "Заказчик";
                ShveiEntities.GetContext.Polzovatels.Add(p);
                ShveiEntities.GetContext.SaveChanges();
                MessageBox.Show("Пользователь зарегистрирован");
                new AuthWindow().Show();
                this.Close();
            }
            else MessageBox.Show("Заполните данные");
        }
    }
}
