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

namespace praktika1en
{
    /// <summary>
    /// Логика взаимодействия для vtoroe.xaml
    /// </summary>
    public partial class vtoroe : Window
    {
        private praktikaEntities context = new praktikaEntities();
        public vtoroe()
        {
            InitializeComponent();
            dg2.ItemsSource = context.Mesto.ToList();
        }

        private void cl2(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
