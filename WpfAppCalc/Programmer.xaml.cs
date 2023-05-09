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

namespace WpfAppCalc
{
    /// <summary>
    /// Логика взаимодействия для Programmer.xaml
    /// </summary>
    public partial class Programmer : Window
    {
        public Programmer()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mWindow = new MainWindow();
            mWindow.Show();
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Inger inger = new Inger();
            inger.Show();
            this.Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Plotting plotting = new Plotting();
            plotting.Show();
            this.Close();
        }
    }
}
