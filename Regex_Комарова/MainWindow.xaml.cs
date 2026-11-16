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

namespace Regex_Комарова
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Classes.Passport> Passports = new List<Classes.Passport>();
        /// <summary> Ссылка на инициализированное главное окно </summary>
        public static MainWindow init;
        public MainWindow()
        {
            InitializeComponent();
            // Запоминаем в переменную проинициализированное главное окно
            init = this;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            new Windows.Add(null).ShowDialog();
        }

        private void Update(object sender, RoutedEventArgs e)
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {

        }
        public void LoadPassport(object sender, RoutedEventArgs e)
        {

        }
    }
}
