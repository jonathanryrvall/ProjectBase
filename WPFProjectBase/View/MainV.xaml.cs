using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WPFProjectBase.ViewModel;

namespace WPFProjectBase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainV : Window
    {
        public MainV()
        {
            InitializeComponent();

            // Avoid loading viewmodel in design mode
            if (DesignerProperties.GetIsInDesignMode(this))
            {
                return;
            }

            DataContext = App.Current.Services.GetService(typeof(MainVM));
        }
    }
}
