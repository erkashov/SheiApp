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
    /// Interaction logic for VspolWindow.xaml
    /// </summary>
    public partial class VspolWindow : Window
    {
        public ObservableCollection<Izdelie> IzdeliesList { get; set; }
        public VspolWindow()
        {
            InitializeComponent();
            IzdeliesList = new ObservableCollection<Izdelie>(ShveiEntities.GetContext.Izdelies.ToList());
            this.DataContext = this;
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Global.Izdel = datagrid.SelectedItem as Izdelie;
            this.Close();
        }
    }
}
