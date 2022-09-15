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

namespace Prilojenie
{
    /// <summary>
    /// Логика взаимодействия для VisitorManu.xaml
    /// </summary>
    public partial class VisitorManu : Page
    {
        public VisitorManu()
        {
            InitializeComponent();
        }

        private void Teams_Click(object sender, RoutedEventArgs e)
        {
            Main.MainFrame.Navigate(new TeamDetail());
        }
    }
}
