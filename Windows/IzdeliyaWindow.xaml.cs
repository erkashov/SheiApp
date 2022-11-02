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
    /// Interaction logic for IzdeliyaWindow.xaml
    /// </summary>
    public partial class IzdeliyaWindow : Page
    {
        public ObservableCollection<Izdelie> IzdeliesList { get; set; } 
        public IzdeliyaWindow()
        {
            InitializeComponent();
            IzdeliesList = new ObservableCollection<Izdelie>(ShveiEntities.GetContext.Izdelies.ToList());
            this.DataContext = this;
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow.Frame.Navigate(new IzdelieWindow(datagrid.SelectedItem as Izdelie));
        }
    }
}
