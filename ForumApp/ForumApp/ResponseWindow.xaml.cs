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

namespace ВопросОтвет
{
    /// <summary>
    /// Логика взаимодействия для ResponseWindow.xaml
    /// </summary>
    public partial class ResponseWindow : Window
    {
        public int QueryId = 0;
        public string login = null;
        public ResponseWindow(string ninickname_who_gets_the_answer, int QueryId, string login)
        {
            InitializeComponent();

            title.Content += ninickname_who_gets_the_answer;
            this.QueryId = QueryId;
            this.login = login;
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
