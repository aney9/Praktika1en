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
    /// Логика взаимодействия для tri.xaml
    /// </summary>
    public partial class tri : Window
    {
        private praktikaEntities context = new praktikaEntities();
        public tri()
        {
            InitializeComponent();
            dg3.ItemsSource = context.Orders.ToList();
        }

        private void cl3(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
