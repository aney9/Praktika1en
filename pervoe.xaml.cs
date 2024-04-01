using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
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
        //добавление
        private void cl2(object sender, RoutedEventArgs e)
        {
            Clients client = new Clients();
            client.ClientName = imya.Text;
            client.ClientSurname = fam.Text;
            client.ClientMiddlename = otch.Text;
            client.FanId = fanid.Text;
            client.PhoneNumber = tel.Text;
            client.Email = email.Text;
            context.Clients.Add(client);
            context.SaveChanges();
            dg1.ItemsSource = context.Clients.ToList();
            ochistka();
        }
        //изменение
        private void cl3(object sender, RoutedEventArgs e)
        {
            if (dg1.SelectedItem != null)
            {
                var client = dg1.SelectedItem as Clients;
                client.ClientName = imya.Text;
                client.ClientSurname = fam.Text;
                client.ClientMiddlename = otch.Text;
                client.FanId = fanid.Text;
                client.PhoneNumber = tel.Text;
                client.Email = email.Text;
                context.SaveChanges();
                dg1.ItemsSource = context.Clients.ToList();
                ochistka();
            }
        }
        //удаление
        private void cl4(object sender, RoutedEventArgs e)
        {
            if (dg1.SelectedItem != null)
            {
                context.Clients.Remove(dg1.SelectedItem as Clients);
                context.SaveChanges();
                dg1.ItemsSource = context.Clients.ToList();
                ochistka();
            }

        }
        private void ochistka()
        {
            imya.Text = null;
            fam.Text = null;
            otch.Text = null;
            fanid.Text = null;
            tel.Text = null;
            email.Text = null;
        }

        private void dg1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var proverka = (Clients)dg1.SelectedItem;
            if (proverka != null)
            {
                imya.Text = proverka.ClientName.ToString();
                fam.Text = proverka.ClientSurname.ToString();
                otch.Text = proverka.ClientMiddlename.ToString();
                fanid.Text = proverka.FanId.ToString();
                tel.Text = proverka.PhoneNumber.ToString();
                email.Text = proverka.Email.ToString();
            }
        }
    }
}
