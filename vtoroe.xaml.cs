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
        //добавление
        private void cl1(object sender, RoutedEventArgs e)
        {
            Mesto mesto = new Mesto();
            mesto.Sektor = sekt.Text;
            mesto.Ryad = ryad.Text;
            mesto.Mesto1 = mestoo.Text;
            context.Mesto.Add(mesto);
            context.SaveChanges();
            dg2.ItemsSource = context.Mesto.ToList();
            ochistka();
        }
        //изменение
        private void cl3(object sender, RoutedEventArgs e)
        {
            if (dg2.SelectedItem != null)
            {
                var mesto = dg2.SelectedItem as Mesto;
                mesto.Sektor = sekt.Text;
                mesto.Ryad = ryad.Text;
                mesto.Mesto1 = mestoo.Text;
                context.SaveChanges();
                dg2.ItemsSource = context.Mesto.ToList();
                ochistka();
            }
        }
        //удаление
        private void cl4(object sender, RoutedEventArgs e)
        {
            if (dg2.SelectedItem != null)
            {
                context.Mesto.Remove(dg2.SelectedItem as Mesto);
                context.SaveChanges();
                dg2.ItemsSource = context.Mesto.ToList();
                ochistka();
            }
        }
        private void ochistka()
        {
            sekt.Text = null;
            ryad.Text = null;
            mestoo.Text = null;           
        }

        private void dg2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var proverka = (Mesto)dg2.SelectedItem;
            if (proverka != null)
            {
                sekt.Text = proverka.Sektor.ToString();
                ryad.Text = proverka.Ryad.ToString();
                mestoo.Text = proverka.Mesto1.ToString();
            }
        }
    }
}
