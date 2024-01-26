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

namespace Зацепин_Михаил_3ИСП9_27.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void ButtonA_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("", UriKind.Relative));
        }

        private void ButtonB_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("", UriKind.Relative));
        }
    }
}
