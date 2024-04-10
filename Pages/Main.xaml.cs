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

namespace _6Variant_Graf.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public MainWindow mw;

        public Main(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
            LoadZvonki();
        }
        public void LoadZvonki()
        {
            parent.Children.Clear();
            foreach(Classes.Zvonki item in mw.zvonki)
            {
                parent.Children.Add(new Elements.ZvonkiItm(mw, item));
            }
        }

        private void Exit_button(object sender, RoutedEventArgs e)
        {
            mw.Close();
        }

        private void Add_Button(object sender, RoutedEventArgs e)
        {
            mw.frame.Navigate(new Pages.Add(mw));
        }
    }
}
