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
    /// Логика взаимодействия для Туда.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            //bool chek = true;

            //if (nicknameTextBox.Text.Length == 0)
            //{
            //    chek = false;
            //}

            //if (passwordBox.Password.Length == 0)
            //{
            //    chek = false;
            //}

            //if (chek)
            //    this.DialogResult = true;
            //else MessageBox.Show("Ошибка входа!\nПовторите попытку.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);

        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            //this.DialogResult = false;
        }
    }
}
