using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
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

namespace _6Variant_Graf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Classes.Zvonki> zvonki = new List<Classes.Zvonki>();

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                Zvonki();
                frame.Navigate(new Pages.Main(this));
            }
            catch
            {
                MessageBox.Show("Нет подключения к базе данных!");
                this.Close();
            }
        }
        public MySqlDataReader Connection(string query)
        {
            string connect = "server=localhost;port=3309;database=Reestr_zvonkov;uid=root;";
            MySqlConnection mySqlConnection = new MySqlConnection(connect);
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            return mySqlCommand.ExecuteReader();
        }
        public void Zvonki()
        {
            zvonki.Clear();
            MySqlDataReader itemquery = Connection("SELECT * FROM Reestr_zvonkov.zvonki_table");
            while(itemquery.Read())
            {
                zvonki.Add(new Classes.Zvonki(
                    itemquery.GetInt32(0),
                    itemquery.GetString(1),
                    itemquery.GetString(2),
                    itemquery.GetString(3),
                    itemquery.GetString(4),
                    itemquery.GetString(5)
                    ));
            }
            itemquery.Close();
        }
    }
}
