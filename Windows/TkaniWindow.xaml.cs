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
    /// Interaction logic for TkaniWindow.xaml
    /// </summary>
    public partial class TkaniWindow : Page
    {
        public ObservableCollection<Tkan> TkaniList { get; set; }
        public TkaniWindow()
        {
            InitializeComponent();
            TkaniList = new ObservableCollection<Tkan>(ShveiEntities.GetContext.Tkans.ToList());
            this.DataContext = this;
        }
    }
}
