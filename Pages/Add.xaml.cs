using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace _6Variant_Graf.Pages
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        public MainWindow mw;
        public Add(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }

        private void Add_Button(object sender, RoutedEventArgs e)
        {
            if (!Regex.IsMatch(number.Text, @"^\+7\d{10}$") || number.Text == "")
            {
                MessageBox.Show("1");
                return;
            }
            if (!Regex.IsMatch(category.Text, "[а-яА-Я]") || category.Text == "")
            {
                MessageBox.Show("2");
                return;
            }
            if (!Regex.IsMatch(date.Text, "[0-2][0-9]:[0-5][0-9]") || date.Text == "")
            {
                MessageBox.Show("3");
                return;
            }
        }
    }
}
