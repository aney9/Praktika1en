using System;
using System.Collections.Generic;
using System.Data;
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

        private void vyhod(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void dobavl(object sender, RoutedEventArgs e)
        {
            Orders orders = new Orders();
            DateTime data1 = Convert.ToDateTime(data.Text);
            decimal price1 = Convert.ToDecimal(price.Text);
            int ID11 = Convert.ToInt32(ID1.Text);
            int ID22 = Convert.ToInt32(ID2.Text);
            orders.DataPokupki = data1;
            orders.Price = price1;
            orders.clients_ID = ID11;
            orders.mesto_ID = ID22;
            context.Orders.Add(orders);
            context.SaveChanges();
            dg3.ItemsSource = context.Orders.ToList();
            ochistka();
        }

        private void izmen(object sender, RoutedEventArgs e)
        {
            if (dg3.SelectedItem != null)
            {
                var orders = dg3.SelectedItem as Orders;
                DateTime data1 = Convert.ToDateTime(data.Text);
                decimal price1 = Convert.ToDecimal(price.Text);
                int ID11 = Convert.ToInt32(ID1.Text);
                int ID22 = Convert.ToInt32(ID2.Text);
                orders.DataPokupki = data1;
                orders.Price = price1;
                orders.clients_ID = ID11;
                orders.mesto_ID = ID22;
                context.SaveChanges();
                dg3.ItemsSource = context.Orders.ToList();
                ochistka();
            }
        }

        private void udal(object sender, RoutedEventArgs e)
        {
            if (dg3.SelectedItem != null)
            {
                context.Orders.Remove(dg3.SelectedItem as Orders);
                context.SaveChanges();
                dg3.ItemsSource = context.Orders.ToList();
                ochistka();
            }
        }
        private void ochistka()
        {
            data.Text = null;
            price.Text = null;
            ID1.Text = null;
            ID2.Text = null;
        }
        private void dg3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var proverka = (Orders)dg3.SelectedItem;
            if (proverka != null)
            {
                data.Text = proverka.DataPokupki.ToString();
                price.Text = proverka.Price.ToString();
                ID1.Text = proverka.clients_ID.ToString();
                ID2.Text = proverka.ID_orders.ToString();
            }
        }
    }
}
