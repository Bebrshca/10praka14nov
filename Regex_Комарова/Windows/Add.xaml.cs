using Microsoft.Win32;
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

namespace Regex_Комарова.Windows
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Classes.Passport EditPassports;
        public Add(Classes.Passport EditPassport)
        {
            InitializeComponent();
            if(EditPassport != null)
            {
                Name.Text = EditPassport.Name;
                FirstName.Text = EditPassports.FirstName;
                LastName.Text = EditPassports.LastName;
                Issued.Text = EditPassports.Issued;
                DateOfIssued.Text = EditPassports.DateOfIssued;
                DepartmentCode.Text = EditPassports.DepartmentCode;
                SeriesAndNumber.Text = EditPassports.SeriesAndNumber;
                DateOfBirth.Text = EditPassports.DateOfBirth;
                PlaceOfBirth.Text = EditPassports.PlaceOfBirth;
                this.EditPassports = EditPassports;
                if (!string.IsNullOrEmpty(EditPassports.ImagePath))
                {
                    _selectedImagePath = EditPassports.ImagePath;
                    PreviewImage.Source = new BitmapImage(new Uri(_selectedImagePath));
                }
            }
                BthAdd.Content = "Изменить";
        }
        private string _selectedImagePath = null;

        private void SelectImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Images|*.jpg;*.png" };
            if (ofd.ShowDialog() == true)
            {
                _selectedImagePath = ofd.FileName;
                PreviewImage.Source = new BitmapImage(new Uri(_selectedImagePath));
            }
        }
        //смс задание
        private void AddPassport(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Name.Text) || !Classes.Common.CheckRegex.Match(@"^[a-я-А-я]$*", Name.Text))
            {
                MessageBox.Show("Не правильно указано имя пользователя");
                return;
            }
            if (string.IsNullOrEmpty(FirstName.Text) || !Classes.Common.CheckRegex.Match(@"^[a-я-А-я]$*", FirstName.Text))
            {
                MessageBox.Show("Не правильно указано фамилия пользователя");
                return;
            }
            if (string.IsNullOrEmpty(LastName.Text) || !Classes.Common.CheckRegex.Match(@"^[a-я-А-я]$*", LastName.Text))
            {
                MessageBox.Show("Не правильно указано отчество пользователя");
                return;
            }
            if (string.IsNullOrEmpty(Issued.Text) || !Classes.Common.CheckRegex.Match(@"^[а-яА-ЯёЁ\s\.\-\""]+$", Issued.Text))
            {
                MessageBox.Show("Не правильно указано, кем выдан паспорт");
                return;
            }
            if (string.IsNullOrEmpty(DateOfIssued.Text) || !Classes.Common.CheckRegex.Match(@"^\d{2}\.\d{2}\.\d{4}$", DateOfIssued.Text))
            {
                MessageBox.Show("Не правильно указана дата выдачи (формат ДД.ММ.ГГГГ)");
                return;
            }
            if (string.IsNullOrEmpty(DepartmentCode.Text) || !Classes.Common.CheckRegex.Match(@"^\d{3}-\d{3}$", DepartmentCode.Text))
            {
                MessageBox.Show("Не правильно указан код подразделения (формат XXX-XXX)");
                return;
            }
            if (string.IsNullOrEmpty(SeriesAndNumber.Text) || !Classes.Common.CheckRegex.Match(@"^\d{4}\s\d{6}$", SeriesAndNumber.Text))
            {
                MessageBox.Show("Не правильно указана серия и номер (формат XXXX XXXXXX)");
                return;
            }
            if (string.IsNullOrEmpty(DateOfBirth.Text) || !Classes.Common.CheckRegex.Match(@"^\d{2}\.\d{2}\.\d{4}$", DateOfBirth.Text))
            {
                MessageBox.Show("Не правильно указана дата рождения (формат ДД.ММ.ГГГГ)");
                return;
            }
            if (string.IsNullOrEmpty(PlaceOfBirth.Text) || !Classes.Common.CheckRegex.Match(@"^[а-яА-ЯёЁ\s\,\-\.]+$", PlaceOfBirth.Text))
            {
                MessageBox.Show("Не правильно указано место рождения");
                return;
            }
            if (EditPassports == null)
            {
                EditPassports = new Classes.Passport();
                MainWindow.init.Passports.Add(EditPassports);
            }
            EditPassports.ImagePath = _selectedImagePath;
            EditPassports.Name = Name.Text;
            EditPassports.FirstName = FirstName.Text;
            EditPassports.LastName = LastName.Text;
            EditPassports.Issued = Issued.Text;
            EditPassports.DateOfIssued = DateOfIssued.Text;
            EditPassports.DepartmentCode = DepartmentCode.Text;
            EditPassports.SeriesAndNumber = SeriesAndNumber.Text;
            EditPassports.DateOfBirth = DateOfBirth.Text;
            EditPassports.PlaceOfBirth = PlaceOfBirth.Text;
            MainWindow.init.LoadPassport();
            this.Close();
        }
    }
    
}
