using SheiApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Zakazy.xaml
    /// </summary>
    public partial class Zakazy : Page
    {
        public ObservableCollection<Zakaz> ZakazyList { get; set; }
        public Zakazy()
        {
            InitializeComponent();
            ZakazyList = new ObservableCollection<Zakaz>(ShveiEntities.GetContext.Zakazs.Where(p=>p.Polzovatel1 == null || p.Polzovatel1.Login == Global.Polzovatel.Login || p.Polzovatel.Login == Global.Polzovatel.Login).ToList());
            this.DataContext = this;
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Frame.Navigate(new ZakazWindow((datagrid.SelectedItem as Zakaz)));
        }

        private void newBtn_Click(object sender, RoutedEventArgs e)
        {
            Zakaz zakaz = new Zakaz();
            zakaz.Nomer = ShveiEntities.GetContext.Zakazs.Max(p => p.Nomer) + 1;
            zakaz.Data = DateTime.Now;
            if (Global.Polzovatel.Role != "Заказчик")
            {
                zakaz.Polzovatel1 = Global.Polzovatel;
                zakaz.LoginMenedzhera = Global.Polzovatel.Login;
            }
            else
            {
                zakaz.Polzovatel = Global.Polzovatel;
                zakaz.LoginPolzovateleya = Global.Polzovatel.Login;
            }
            zakaz.Etap = "Новый";
            ShveiEntities.GetContext.Zakazs.Add(zakaz);
            MainWindow.Frame.Navigate(new ZakazWindow(zakaz));
        }
    }
}
