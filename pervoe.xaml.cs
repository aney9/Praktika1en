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
    /// Логика взаимодействия для pervoe.xaml
    /// </summary>
    public partial class pervoe : Window
    {
        private praktikaEntities context = new praktikaEntities();
        public pervoe()
        {
            InitializeComponent();
            dg1.ItemsSource = context.Clients.ToList();
        }

        private void cl1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
