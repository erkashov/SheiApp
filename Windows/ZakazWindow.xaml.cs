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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SheiApp.Windows
{
    /// <summary>
    /// Interaction logic for ZakazWindow.xaml
    /// </summary>
    public partial class ZakazWindow : Page
    {
        public Zakaz Zakaz { get; set; }
        public List<Polzovatel> Polzovatels { get; set; }
        public ZakazWindow(Zakaz zak)
        {
            InitializeComponent();
            Zakaz = zak;
            Polzovatels = ShveiEntities.GetContext.Polzovatels.ToList();
            this.DataContext = this;

            zakazchikTB.IsEnabled = Zakaz.Polzovatel == null;
            if (Zakaz.Polzovatel1 == null && Global.Polzovatel.Role == "Менеджер") Zakaz.LoginMenedzhera = Global.Polzovatel.Login;
            sohrBtn_Click(null, null);
            statusTB.IsEnabled = Global.Polzovatel.Role != "Заказчик";
            this.IsEnabled = Zakaz.Etap != "К оплате" || Global.Polzovatel.Role != "Заказчик";
        }

        private void sohrBtn_Click(object sender, RoutedEventArgs e)
        {
            //ShveiEntities.GetContext.Zakazs.Where(p => p.Nomer == Zakaz.Nomer).FirstOrDefault() = Zakaz;
            ShveiEntities.GetContext.SaveChanges();
            this.DataContext = null;
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if((sender as Button).DataContext as ZakazannieIzdeliya  != null)
            {
                ShveiEntities.GetContext.ZakazannieIzdeliyas.Remove((sender as Button).DataContext as ZakazannieIzdeliya);
                sohrBtn_Click(null, null);
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            VspolWindow vspolWindow = new VspolWindow();
            vspolWindow.ShowDialog();
            if(Global.Izdel != null)
            {
                Zakaz.ZakazannieIzdeliyas.Add(new ZakazannieIzdeliya() { NomerZakaza = Zakaz.Nomer, Kolichestvo = "0", ArticulIzdeliya = Global.Izdel.Articul });
                sohrBtn_Click(null, null);
            }
        }
    }
}
