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

namespace _6Variant_Graf.Elements
{
    /// <summary>
    /// Логика взаимодействия для ZvonkiItm.xaml
    /// </summary>
    public partial class ZvonkiItm : UserControl
    {
        public MainWindow mw;
        public Classes.Zvonki item;

        public ZvonkiItm(MainWindow mw, Classes.Zvonki item)
        {
            InitializeComponent();
            this.mw = mw;
            this.item = item;

            Number_phone.Content = "Номер телефона: " + item.Number_phone;
            Category_zvonkov.Content = "Категория звонка: " + item.Category_zvonkov;
            Date.Content = "Дата звонка: " + item.Date;
            Time_of_start.Content = "Начало звонка: " + item.Time_of_start;
            Time_of_end.Content = "Конец звонка: " + item.Time_of_end;
        }

        private void Edit_Button(object sender, RoutedEventArgs e)
        {
            mw.frame.Navigate(new Pages.Edit(mw, item));
        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            string query = $"DELETE FROM `zvonki_table` WHERE 'zvonki_table','Id' = '{item.Id}'";
            mw.Connection(query);
            mw.Zvonki();
            mw.frame.Navigate(new Pages.Main(mw));
            MessageBox.Show("Удалено!");
        }
    }
}
