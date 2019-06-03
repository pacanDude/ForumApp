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

namespace окна
{
    /// <summary>
    /// Логика взаимодействия для Сюда.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            //bool chek = true;

            //if (nameTextBox.Text.Length == 0)
            //{
            //    warning1.Visibility = Visibility.Visible;
            //    chek = false;
            //}

            //if (nicknameTextBox.Text.Length < 3)
            //{
            //    warning2.Visibility = Visibility.Visible;
            //    chek = false;
            //}

            //if (passwordBox.Password.Length < 6)
            //{
            //    warning3.Visibility = Visibility.Visible;
            //    chek = false;
            //}

            //if (passwordBox.Password.Length != confirmPasswordBox.Password.Length || passwordBox.Password != confirmPasswordBox.Password)
            //{
            //    warning4.Visibility = Visibility.Visible;
            //    chek = false;
            //}

            //if (chek)
            //    this.DialogResult = true;
            //else MessageBox.Show("Введены не все данные либо допущены ошибки в заполнении.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);

        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            //this.DialogResult = false;
        }
    }
}
